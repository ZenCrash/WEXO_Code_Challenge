using System.Text.Json.Serialization;

namespace WEXOFlix_MVC.Models.Models
{

    public class PlprogramTag
    {
        [JsonPropertyName("plprogram$scheme")]
        public string PlprogramScheme { get; set; }

        [JsonPropertyName("plprogram$title")]
        public string PlprogramTitle { get; set; }

        [JsonPropertyName("plprogram$titleLocalized")]
        public PlprogramTitleLocalized PlprogramTitleLocalized { get; set; }
    }

}