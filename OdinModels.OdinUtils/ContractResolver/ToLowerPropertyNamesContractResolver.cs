using Newtonsoft.Json.Serialization;

namespace OdinModels.OdinUtils.ContractResolver
{
    public class ToLowerPropertyNamesContractResolver : DefaultContractResolver
    {
        public ToLowerPropertyNamesContractResolver()
        {
            NamingStrategy = new NamingStrategyToLower();
        }
    }
}