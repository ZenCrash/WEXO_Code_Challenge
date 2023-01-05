using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WEXOFlix_MVC.Models.Models
{

    public class PlprogramavailabilityMedium
    {
        [JsonPropertyName("media$content")]
        public List<MediaContent> MediaContent { get; set; }

        [JsonPropertyName("plmedia$publicUrl")]
        public string PlmediaPublicUrl { get; set; }
    }

}