using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
