using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WEXOFlix_MVC.Models.Models.Formats
{

    public class Orig3508x5906
    {
        [JsonPropertyName("plprogram$url")]
        public string PlprogramUrl { get; set; }

        [JsonPropertyName("plprogram$width")]
        public int? PlprogramWidth { get; set; }

        [JsonPropertyName("plprogram$height")]
        public int? PlprogramHeight { get; set; }

        [JsonPropertyName("plprogram$title")]
        public string PlprogramTitle { get; set; }

        [JsonPropertyName("plprogram$assetTypes")]
        public List<string> PlprogramAssetTypes { get; set; }
    }

}