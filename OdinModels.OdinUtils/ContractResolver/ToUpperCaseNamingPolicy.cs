using System.Text.Json;

namespace OdinModels.OdinUtils.ContractResolver
{
    public class ToUpperCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name) =>
            name.ToUpper();
    }
}