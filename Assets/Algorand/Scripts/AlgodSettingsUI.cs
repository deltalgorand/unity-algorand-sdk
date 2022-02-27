using System.Linq;
using System.Threading;
using AlgoSdk;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AlgodSettingsUI : MonoBehaviour
{
    public Algod algod;

    public InputField addressField;

    public InputField tokenField;

    public InputField customHeadersField;

    public Button testConnectionButton;

    public UnityEvent onClientConnected = new UnityEvent();

    CancellationTokenSource testConnectionToken;

    public string Address
    {
        get => algod.Client.Address;
        set => algod.Client = new AlgodClient(value, Token, algod.Client.Headers);
    }

    public string Token
    {
        get => algod.Client.Token;
        set => algod.Client = new AlgodClient(Address, value, algod.Client.Headers);
    }

    public string Headers
    {
        get => Format(algod.Client.Headers);
        set
        {
            if (TryParseHeaders(value, out var headers))
                algod.Client = new AlgodClient(Address, Token, headers);
        }
    }

    public void OnEnable()
    {
        addressField.SetTextWithoutNotify(Address);
        customHeadersField.SetTextWithoutNotify(Headers);
        tokenField.SetTextWithoutNotify(Token);
        TestConnection();
    }

    public void SetAddress(string address) => Address = address;

    public void SetToken(string token) => Token = token;

    public void SetHeaders(string headers) => Headers = headers;

    public void TestConnection()
    {
        if (testConnectionToken != null)
            testConnectionToken.Cancel();
        testConnectionToken = new CancellationTokenSource();
        TestConnectionAsync(testConnectionToken.Token).Forget();
    }

    async UniTaskVoid TestConnectionAsync(CancellationToken cancellationToken)
    {
        testConnectionButton.enabled = false;
        try
        {
            var healthResponse = await algod.Client.GetHealth();
            if (healthResponse.Error)
                Debug.LogError(healthResponse.Error);
            else
                onClientConnected.Invoke();
        }
        finally
        {
            testConnectionButton.enabled = true;
        }
    }

    string Format(Header[] headers)
    {
        if (headers == null)
            return "";

        return string.Join(",", headers.Select(h => $"{h.Key}: {h.Value}"));
    }

    bool TryParseHeaders(string value, out Header[] headers)
    {
        var triedHeaders = value.Split(",")
            .Select(TryParseHeader);

        headers = triedHeaders.Select(result => result.header).ToArray();
        return triedHeaders.All(result => result.success);
    }

    (bool success, Header header) TryParseHeader(string value)
    {
        var split = value.Split(":");
        if (split.Length != 1)
            return (false, default);

        return (true, (split[0], split[1]));
    }
}
