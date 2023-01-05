using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WEXOFlix_MVC.Models.Models
{

    public class PlprogramRating
    {
        [JsonPropertyName("plprogram$scheme")]
        public string PlprogramScheme { get; set; }

        [JsonPropertyName("plprogram$rating")]
        public string PlprogramRating { get; set; }

        [JsonPropertyName("plprogram$subRatings")]
        public List<object> PlprogramSubRatings { get; set; }
    }

}