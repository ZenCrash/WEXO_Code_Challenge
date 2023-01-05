using System.Text.Json.Serialization;

namespace WEXOFlix_MVC.Models.Models
{

    public class Xmlns
    {
        [JsonPropertyName("dcterms")]
        public string Dcterms { get; set; }

        [JsonPropertyName("media")]
        public string Media { get; set; }

        [JsonPropertyName("tdc")]
        public string Tdc { get; set; }

        [JsonPropertyName("pl1")]
        public string Pl1 { get; set; }

        [JsonPropertyName("pl")]
        public string Pl { get; set; }

        [JsonPropertyName("pla")]
        public string Pla { get; set; }

        [JsonPropertyName("pllisting")]
        public string Pllisting { get; set; }

        [JsonPropertyName("plprogram")]
        public string Plprogram { get; set; }

        [JsonPropertyName("plprogramavailability")]
        public string Plprogramavailability { get; set; }

        [JsonPropertyName("plmedia")]
        public string Plmedia { get; set; }

        [JsonPropertyName("plfile")]
        public string Plfile { get; set; }

        [JsonPropertyName("plrelease")]
        public string Plrelease { get; set; }
    }

}