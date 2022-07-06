using System.Text.Json;

namespace OdinModels.OdinUtils.ContractResolver
{
    public class LowerCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name) =>
            name.ToLower();
    }
}