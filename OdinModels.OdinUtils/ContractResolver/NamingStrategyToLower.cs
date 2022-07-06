using Newtonsoft.Json.Serialization;

namespace OdinModels.OdinUtils.ContractResolver
{
    public class NamingStrategyToLower : NamingStrategy
    {
        protected override string ResolvePropertyName(string name)
        {
            return name.ToLower();
        }
    }
}