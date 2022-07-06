using Newtonsoft.Json;

namespace OdinModels.OdinUtils.Utils.OdinHttp.Models
{
    [JsonObject(MemberSerialization.OptOut)]
    public class UpLoadSmFile
    {
        public long FileSize { get; set; }
        public string FileName { get; set; }
        [JsonIgnore]
        public byte[] FileContent { get; set; }
    }
}