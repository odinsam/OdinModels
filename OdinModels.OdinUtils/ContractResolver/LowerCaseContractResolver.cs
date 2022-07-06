using Newtonsoft.Json.Serialization;

namespace OdinModels.OdinUtils.ContractResolver
{
    public class LowerCaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToLower();
        }
    }
}