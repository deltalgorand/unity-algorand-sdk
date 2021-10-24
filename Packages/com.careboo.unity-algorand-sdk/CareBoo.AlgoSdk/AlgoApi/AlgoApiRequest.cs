using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cysharp.Threading.Tasks;
using Unity.Collections;
using UnityEngine.Networking;
using static Cysharp.Threading.Tasks.UnityAsyncExtensions;

namespace AlgoSdk
{
    /// <summary>
    /// A wrapper around <see cref="UnityWebRequest"/> for handling requests
    /// to Algorand REST services.
    /// </summary>
    public readonly ref struct AlgoApiRequest
    {
        readonly UnityWebRequest unityWebRequest;

        private AlgoApiRequest(ref UnityWebRequest unityWebRequest)
        {
            this.unityWebRequest = unityWebRequest;
        }

        /// <summary>
        /// Set the token used for authenticating to the service.
        /// </summary>
        /// <param name="tokenHeader">The name of the request header used for the token.</param>
        /// <param name="token">The token used for authenticating to the service.</param>
        /// <returns><see cref="this"/> with token set</returns>
        public AlgoApiRequest SetToken(string tokenHeader, string token)
        {
            if (!string.IsNullOrEmpty(token))
                unityWebRequest.SetRequestHeader(tokenHeader, token);
            return this;
        }

        /// <summary>
        /// Send the request.
        /// </summary>
        /// <param name="cancellationToken">An optional cancellation token</param>
        /// <returns>A <see cref="Sent"/> request</returns>
        public Sent Send(CancellationToken cancellationToken = default)
        {
            return new Sent(unityWebRequest.SendWebRequest(), cancellationToken);
        }

        /// <summary>
        /// Send the request and check progress callbacks using <see cref="IProgress{System.Single}"/>
        /// </summary>
        /// <typeparam name="TProgress">A progress callback implementing <see cref="IProgress{System.Single}"/></typeparam>
        /// <param name="progress">The progress callback</param>
        /// <param name="cancellationToken">An optional cancellation token</param>
        /// <returns>A <see cref="Sent{TProgress}"/> request</returns>
        public Sent<TProgress> Send<TProgress>(TProgress progress, CancellationToken cancellationToken = default)
            where TProgress : IProgress<float>
        {
            return new Sent<TProgress>(unityWebRequest.SendWebRequest(), progress, cancellationToken);
        }

        /// <summary>
        /// Set body of the request, and set its content type header to "application/json"
        /// </summary>
        /// <param name="json">The utf8 json to set the body of the request</param>
        /// <returns>this request with body and header set</returns>
        public AlgoApiRequest SetJsonBody(string json) =>
            SetRawBody(Encoding.UTF8.GetBytes(json), ContentType.Json);

        /// <summary>
        /// Set body of the request, and set its content type header to "application/json"
        /// </summary>
        /// <param name="json">The utf8 json to set the body of the request</param>
        /// <returns>this request with body and header set</returns>
        public AlgoApiRequest SetJsonBody(NativeText json) =>
            SetRawBody(json.AsArray().ToArray(), ContentType.Json);

        /// <summary>
        /// Set body of the request, and set its content type header to "application/json"
        /// </summary>
        /// <typeparam name="TBody">Type of the object to serialize</typeparam>
        /// <param name="value">An object to serialize into json, then to set in the body of the request</param>
        /// <returns>this request with body and header set</returns>
        public AlgoApiRequest SetJsonBody<TBody>(TBody value)
        {
            using var json = AlgoApiSerializer.SerializeJson(value, Allocator.Temp);
            return SetJsonBody(json);
        }

        /// <summary>
        /// Set body of the request, and set its content type header to "application/text"
        /// </summary>
        /// <param name="plainText">The utf8 plaintext to use for the body</param>
        /// <returns>this request with body and header set</returns>
        public AlgoApiRequest SetPlainTextBody(string plainText) =>
            SetRawBody(Encoding.UTF8.GetBytes(plainText), ContentType.PlainText);

        /// <summary>
        /// Set body of the request and set its content type header to "application/msgpack"
        /// </summary>
        /// <param name="bytes">The msgpack bytes to set for the body</param>
        /// <returns>this request with body and header set</returns>
        public AlgoApiRequest SetMessagePackBody(NativeArray<byte>.ReadOnly bytes) =>
            SetRawBody(bytes.ToArray(), ContentType.MessagePack);

        /// <summary>
        /// Set the body and content type header of the request
        /// </summary>
        /// <param name="data">The raw bytes to set for the body</param>
        /// <param name="contentType">The content type to set the header of the request</param>
        /// <returns>this request with body and header set</returns>
        public AlgoApiRequest SetRawBody(byte[] data, ContentType contentType)
        {
            if (data == null || data.Length == 0)
            {
                unityWebRequest.SetRequestHeader("Content-Type", contentType.ToHeaderValue());
                return this;
            }
            unityWebRequest.uploadHandler = new UploadHandlerRaw(data);
            unityWebRequest.uploadHandler.contentType = contentType.ToHeaderValue();
            unityWebRequest.disposeUploadHandlerOnDispose = true;
            return this;
        }

        /// <summary>
        /// Create a GET request
        /// </summary>
        /// <param name="url">The url for this request</param>
        /// <returns>A new GET request</returns>
        public static AlgoApiRequest Get(string url)
        {
            var webRequest = UnityWebRequest.Get(url);
            return new AlgoApiRequest(ref webRequest);
        }

        /// <summary>
        /// Create a POST request
        /// </summary>
        /// <param name="url">The url for this request</param>
        /// <returns>A new POST request</returns>
        public static AlgoApiRequest Post(string url)
        {
            var webRequest = UnityWebRequestPostWithoutBody(url);
            return new AlgoApiRequest(ref webRequest);
        }

        /// <summary>
        /// Create a DELETE request
        /// </summary>
        /// <param name="url">The url for this request</param>
        /// <returns>A new DELETE request</returns>
        public static AlgoApiRequest Delete(string url)
        {
            var webRequest = UnityWebRequest.Delete(url);
            return new AlgoApiRequest(ref webRequest);
        }

        static UnityWebRequest UnityWebRequestPostWithoutBody(string url)
        {
            return new UnityWebRequest()
            {
                method = UnityWebRequest.kHttpVerbPOST,
                url = url,
                downloadHandler = new DownloadHandlerBuffer(),
                disposeDownloadHandlerOnDispose = true
            };
        }

        /// <summary>
        /// A wrapper around the <see cref="UnityWebRequestAsyncOperation"/> handling the sent request.
        /// </summary>
        public ref struct Sent
        {
            UnityWebRequestAsyncOperation asyncOperation;
            CancellationToken cancellationToken;

            public Sent(
                UnityWebRequestAsyncOperation asyncOperation,
                CancellationToken cancellationToken = default
            )
            {
                this.asyncOperation = asyncOperation;
                this.cancellationToken = cancellationToken;
            }

            public Awaiter GetAwaiter()
            {
                var uniTaskAwaiter = asyncOperation
                    .ToUniTask(cancellationToken: cancellationToken)
                    .GetAwaiter();
                return new Awaiter(uniTaskAwaiter);
            }
        }

        /// <summary>
        /// A wrapper around the <see cref="UnityWebRequestAsyncOperation"/> handling the sent request.
        /// </summary>
        public ref struct Sent<TProgress> where TProgress : IProgress<float>
        {
            UnityWebRequestAsyncOperation asyncOperation;
            TProgress progress;
            CancellationToken cancellationToken;

            public Sent(
                UnityWebRequestAsyncOperation asyncOperation,
                TProgress progress,
                CancellationToken cancellationToken = default
            )
            {
                this.asyncOperation = asyncOperation;
                this.progress = progress;
                this.cancellationToken = cancellationToken;
            }

            public Awaiter GetAwaiter()
            {
                var uniTaskAwaiter = asyncOperation
                    .ToUniTask(progress: progress, cancellationToken: cancellationToken)
                    .GetAwaiter();
                return new Awaiter(uniTaskAwaiter);
            }
        }

        /// <summary>
        /// A Task Awaiter for <see cref="UnityWebRequest"/>
        /// </summary>
        public readonly struct Awaiter : ICriticalNotifyCompletion
        {
            readonly UniTask<UnityWebRequest>.Awaiter uniTaskAwaiter;

            public Awaiter(UniTask<UnityWebRequest>.Awaiter uniTaskAwaiter)
            {
                this.uniTaskAwaiter = uniTaskAwaiter;
            }

            public bool IsCompleted => uniTaskAwaiter.IsCompleted;

            public AlgoApiResponse GetResult()
            {
                UnityWebRequest completedRequest;
                try
                {
                    completedRequest = uniTaskAwaiter.GetResult();
                }
                catch (UnityWebRequestException webErr)
                {
                    completedRequest = webErr.UnityWebRequest;
                }
                return new AlgoApiResponse(completedRequest);
            }

            public void OnCompleted(Action continuation)
            {
                UnsafeOnCompleted(continuation);
            }

            public void UnsafeOnCompleted(Action continuation)
            {
                uniTaskAwaiter.UnsafeOnCompleted(continuation);
            }
        }
    }
}