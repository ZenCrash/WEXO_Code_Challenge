using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WEXOFlix_MVC.Models.Models
{

    public class Root
    {
        [JsonPropertyName("$xmlns")]
        public Xmlns Xmlns { get; set; }

        [JsonPropertyName("startIndex")]
        public int? StartIndex { get; set; }

        [JsonPropertyName("itemsPerPage")]
        public int? ItemsPerPage { get; set; }

        [JsonPropertyName("entryCount")]
        public int? EntryCount { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("tdc$feedContentType")]
        public string TdcFeedContentType { get; set; }

        [JsonPropertyName("entries")]
        public List<Entry> Entries { get; set; }
    }

}