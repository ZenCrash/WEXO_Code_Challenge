using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WEXOFlix_MVC.Models.Models
{

    public class MediaContent
    {
        [JsonPropertyName("plfile$bitrate")]
        public int? PlfileBitrate { get; set; }

        [JsonPropertyName("plfile$duration")]
        public double? PlfileDuration { get; set; }

        [JsonPropertyName("plfile$format")]
        public string PlfileFormat { get; set; }

        [JsonPropertyName("plfile$height")]
        public int? PlfileHeight { get; set; }

        [JsonPropertyName("plfile$width")]
        public int? PlfileWidth { get; set; }

        [JsonPropertyName("plfile$assetTypes")]
        public List<string> PlfileAssetTypes { get; set; }

        [JsonPropertyName("plfile$isProtected")]
        public bool? PlfileIsProtected { get; set; }

        [JsonPropertyName("plfile$releases")]
        public List<PlfileRelease> PlfileReleases { get; set; }

        [JsonPropertyName("plfile$protectionScheme")]
        public string PlfileProtectionScheme { get; set; }
    }

}