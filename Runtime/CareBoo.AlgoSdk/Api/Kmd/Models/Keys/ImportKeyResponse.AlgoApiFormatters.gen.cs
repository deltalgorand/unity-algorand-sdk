//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk
{
    
    
    public partial struct ImportKeyResponse
    {
        
        private static bool @__generated__IsValid = ImportKeyResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.ImportKeyResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.ImportKeyResponse>(false).Assign("address", null, (AlgoSdk.ImportKeyResponse x) => x.Address, (ref AlgoSdk.ImportKeyResponse x, AlgoSdk.Address value) => x.Address = value, false).Assign("error", null, (AlgoSdk.ImportKeyResponse x) => x.Error, (ref AlgoSdk.ImportKeyResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value, false).Assign("message", null, (AlgoSdk.ImportKeyResponse x) => x.Message, (ref AlgoSdk.ImportKeyResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance, false));
            return true;
        }
    }
}
