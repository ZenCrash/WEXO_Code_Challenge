using System.Text.Json.Serialization;

namespace WEXOFlix_MVC.Models.Models
{

    public class PlprogramCredit
    {
        [JsonPropertyName("plprogram$creditType")]
        public string PlprogramCreditType { get; set; }

        [JsonPropertyName("plprogram$personId")]
        public string PlprogramPersonId { get; set; }

        [JsonPropertyName("plprogram$personName")]
        public string PlprogramPersonName { get; set; }
    }

}