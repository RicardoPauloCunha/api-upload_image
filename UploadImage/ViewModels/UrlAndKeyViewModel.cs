using Newtonsoft.Json;

namespace UploadImage.ViewModels
{
    public class UrlAndKeyViewModel
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; private set; }
    }
}
