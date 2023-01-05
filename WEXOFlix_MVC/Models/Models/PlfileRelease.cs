using System.Text.Json.Serialization;

namespace WEXOFlix_MVC.Models.Models
{

    public class PlfileRelease
    {
        [JsonPropertyName("plrelease$pid")]
        public string PlreleasePid { get; set; }

        [JsonPropertyName("plrelease$url")]
        public string PlreleaseUrl { get; set; }
    }

}