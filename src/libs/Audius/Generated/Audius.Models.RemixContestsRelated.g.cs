
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemixContestsRelated
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::Audius.User>? Users { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        public global::System.Collections.Generic.IList<global::Audius.Track>? Tracks { get; set; }

        /// <summary>
        /// Per-contest entry counts keyed by the contest's parent track id (hashid). Lets the discovery UI render entry counts without issuing an extra `/tracks/{id}/remixes?limit=0` per card.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entry_counts")]
        public global::System.Collections.Generic.Dictionary<string, long>? EntryCounts { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixContestsRelated" /> class.
        /// </summary>
        /// <param name="users"></param>
        /// <param name="tracks"></param>
        /// <param name="entryCounts">
        /// Per-contest entry counts keyed by the contest's parent track id (hashid). Lets the discovery UI render entry counts without issuing an extra `/tracks/{id}/remixes?limit=0` per card.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemixContestsRelated(
            global::System.Collections.Generic.IList<global::Audius.User>? users,
            global::System.Collections.Generic.IList<global::Audius.Track>? tracks,
            global::System.Collections.Generic.Dictionary<string, long>? entryCounts)
        {
            this.Users = users;
            this.Tracks = tracks;
            this.EntryCounts = entryCounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixContestsRelated" /> class.
        /// </summary>
        public RemixContestsRelated()
        {
        }

    }
}