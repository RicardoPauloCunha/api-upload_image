using Newtonsoft.Json;

namespace UploadImage.ViewModels
{
    public class ResultViewModel
    {
        [JsonProperty(PropertyName = "data")]
        public DataResultViewModel Data { get; private set; }

        [JsonProperty(PropertyName = "success")]
        public string Success { get; private set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }
    }

    public class DataResultViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

        [JsonProperty(PropertyName = "image")]
        public ImageDataResultViewModel Image { get; private set; }

        [JsonProperty(PropertyName = "thumb")]
        public ThumbDataResultViewModel Thumb { get; private set; }

        [JsonProperty(PropertyName = "medium")]
        public MediumDataResultViewModel Medium { get; private set; }
    }

    public class ImageDataResultViewModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "size")]
        public string Size { get; private set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }
    }

    public class ThumbDataResultViewModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "size")]
        public string Size { get; private set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }
    }

    public class MediumDataResultViewModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "size")]
        public string Size { get; private set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }
    }
}
