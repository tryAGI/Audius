
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EventFollowState
    {
        /// <summary>
        /// Whether the authenticated / requested user is currently subscribed to this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_followed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFollowed { get; set; }

        /// <summary>
        /// Total number of users following this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follower_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FollowerCount { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventFollowState" /> class.
        /// </summary>
        /// <param name="isFollowed">
        /// Whether the authenticated / requested user is currently subscribed to this event.
        /// </param>
        /// <param name="followerCount">
        /// Total number of users following this event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EventFollowState(
            bool isFollowed,
            int followerCount)
        {
            this.IsFollowed = isFollowed;
            this.FollowerCount = followerCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventFollowState" /> class.
        /// </summary>
        public EventFollowState()
        {
        }

    }
}