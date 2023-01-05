using System.Text.Json.Serialization;

namespace WEXOFlix_MVC.Models.Models
{

    public class PlprogramTitleLocalized
    {
        [JsonPropertyName("no")]
        public string No { get; set; }

        [JsonPropertyName("fi")]
        public string Fi { get; set; }

        [JsonPropertyName("sv")]
        public string Sv { get; set; }

        [JsonPropertyName("da")]
        public string Da { get; set; }
    }

}