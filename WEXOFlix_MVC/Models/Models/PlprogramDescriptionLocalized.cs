using System.Text.Json.Serialization;

namespace WEXOFlix_MVC.Models.Models
{

    public class PlprogramDescriptionLocalized
    {
        [JsonPropertyName("da")]
        public string Da { get; set; }
    }

}