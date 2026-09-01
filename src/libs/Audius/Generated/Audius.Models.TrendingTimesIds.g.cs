
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrendingTimesIds
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("week")]
        public global::System.Collections.Generic.IList<global::Audius.TrackId>? Week { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("month")]
        public global::System.Collections.Generic.IList<global::Audius.TrackId>? Month { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("year")]
        public global::System.Collections.Generic.IList<global::Audius.TrackId>? Year { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingTimesIds" /> class.
        /// </summary>
        /// <param name="week"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrendingTimesIds(
            global::System.Collections.Generic.IList<global::Audius.TrackId>? week,
            global::System.Collections.Generic.IList<global::Audius.TrackId>? month,
            global::System.Collections.Generic.IList<global::Audius.TrackId>? year)
        {
            this.Week = week;
            this.Month = month;
            this.Year = year;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingTimesIds" /> class.
        /// </summary>
        public TrendingTimesIds()
        {
        }

    }
}