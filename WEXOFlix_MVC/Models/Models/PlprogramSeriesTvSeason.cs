using System.Text.Json.Serialization;

namespace WEXOFlix_MVC.Models.Models
{

    public class PlprogramSeriesTvSeason
    {
        [JsonPropertyName("plprogram$guid")]
        public string PlprogramGuid { get; set; }

        [JsonPropertyName("plprogram$title")]
        public string PlprogramTitle { get; set; }

        [JsonPropertyName("plprogram$id")]
        public string PlprogramId { get; set; }

        [JsonPropertyName("plprogram$startYear")]
        public int? PlprogramStartYear { get; set; }

        [JsonPropertyName("plprogram$endYear")]
        public int? PlprogramEndYear { get; set; }

        [JsonPropertyName("plprogram$tvSeasonNumber")]
        public int? PlprogramTvSeasonNumber { get; set; }
    }

}