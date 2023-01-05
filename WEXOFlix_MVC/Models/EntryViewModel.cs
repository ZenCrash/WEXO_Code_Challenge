using System.Text.Json.Serialization;
using System.Collections.Generic;
using WEXOFlix_MVC.Models.Models;

namespace WEXOFlix_MVC.Models
{

    public class EntryViewModel
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("guid")]
        public string? Guid { get; set; }

        [JsonPropertyName("updated")]
        public object? Updated { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("plprogram$credits")]
        public List<PlprogramCredit>? PlprogramCredits { get; set; }

        [JsonPropertyName("plprogram$descriptionLocalized")]
        public PlprogramDescriptionLocalized? PlprogramDescriptionLocalized { get; set; }

        [JsonPropertyName("plprogram$editorialRating")]
        public object? PlprogramEditorialRating { get; set; }

        [JsonPropertyName("plprogram$longDescription")]
        public string? PlprogramLongDescription { get; set; }

        [JsonPropertyName("plprogram$longDescriptionLocalized")]
        public PlprogramLongDescriptionLocalized? PlprogramLongDescriptionLocalized { get; set; }

        [JsonPropertyName("plprogram$programType")]
        public string? PlprogramProgramType { get; set; }

        [JsonPropertyName("plprogram$pubDate")]
        public string? PlprogramPubDate { get; set; }

        [JsonPropertyName("plprogram$ratings")]
        public List<PlprogramRating>? PlprogramRatings { get; set; }

        [JsonPropertyName("plprogram$runtime")]
        public double? PlprogramRuntime { get; set; }

        [JsonPropertyName("plprogram$seriesEpisodeNumber")]
        public object? PlprogramSeriesEpisodeNumber { get; set; }

        [JsonPropertyName("plprogram$seriesId")]
        public object? PlprogramSeriesId { get; set; }

        [JsonPropertyName("plprogram$seriesTvSeasons")]
        public List<PlprogramSeriesTvSeason>? PlprogramSeriesTvSeasons { get; set; }

        [JsonPropertyName("plprogram$tagIds")]
        public List<string>? PlprogramTagIds { get; set; }

        [JsonPropertyName("plprogram$tags")]
        public List<PlprogramTag>? PlprogramTags { get; set; }

        [JsonPropertyName("plprogram$thumbnails")]
        public PlprogramThumbnails? PlprogramThumbnails { get; set; }

        [JsonPropertyName("plprogram$titleLocalized")]
        public PlprogramTitleLocalized? PlprogramTitleLocalized { get; set; }

        [JsonPropertyName("plprogram$tvSeasonEpisodeNumber")]
        public object? PlprogramTvSeasonEpisodeNumber { get; set; }

        [JsonPropertyName("plprogram$tvSeasonId")]
        public object? PlprogramTvSeasonId { get; set; }

        [JsonPropertyName("plprogram$tvSeasonNumber")]
        public object? PlprogramTvSeasonNumber { get; set; }

        [JsonPropertyName("plprogram$year")]
        public int? PlprogramYear { get; set; }

        [JsonPropertyName("plprogramavailability$availableTvSeasonIds")]
        public List<string>? PlprogramavailabilityAvailableTvSeasonIds { get; set; }

        [JsonPropertyName("plprogramavailability$media")]
        public List<PlprogramavailabilityMedium>? PlprogramavailabilityMedia { get; set; }

        [JsonPropertyName("tdc$estProductAvailability")]
        public string? TdcEstProductAvailability { get; set; }

        [JsonPropertyName("tdc$estProductAvailabilityLocalized")]
        public TdcEstProductAvailabilityLocalized? TdcEstProductAvailabilityLocalized { get; set; }

        [JsonPropertyName("tdc$estProductAvailabilityUpdated")]
        public object? TdcEstProductAvailabilityUpdated { get; set; }

        [JsonPropertyName("tdc$imdbId")]
        public string? TdcImdbId { get; set; }

        [JsonPropertyName("tdc$isMetadataAddedByHarverster")]
        public bool? TdcIsMetadataAddedByHarverster { get; set; }

        [JsonPropertyName("tdc$metadataAddedByHarverster")]
        public object? TdcMetadataAddedByHarverster { get; set; }

        [JsonPropertyName("tdc$sortDate")]
        public string? TdcSortDate { get; set; }

        [JsonPropertyName("tdc$tvodProductAvailability")]
        public string? TdcTvodProductAvailability { get; set; }

        [JsonPropertyName("tdc$tvodProductAvailabilityLocalized")]
        public TdcTvodProductAvailabilityLocalized? TdcTvodProductAvailabilityLocalized { get; set; }

        [JsonPropertyName("tdc$urlSlug")]
        public string? TdcUrlSlug { get; set; }

        [JsonPropertyName("tdc$urlSlugLocalized")]
        public TdcUrlSlugLocalized? TdcUrlSlugLocalized { get; set; }

        [JsonPropertyName("tdc$tvodProductAvailabilityUpdated")]
        public long? TdcTvodProductAvailabilityUpdated { get; set; }

        [JsonPropertyName("tdc$seoText")]
        public string? TdcSeoText { get; set; }

        [JsonPropertyName("tdc$seoTextLocalized")]
        public TdcSeoTextLocalized? TdcSeoTextLocalized { get; set; }

        [JsonPropertyName("tdc$youtubeTrailer")]
        public string? TdcYoutubeTrailer { get; set; }
    }

}