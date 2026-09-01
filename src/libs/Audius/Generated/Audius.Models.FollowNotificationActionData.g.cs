
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FollowNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follower_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FollowerUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followee_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FolloweeUserId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowNotificationActionData" /> class.
        /// </summary>
        /// <param name="followerUserId"></param>
        /// <param name="followeeUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FollowNotificationActionData(
            string followerUserId,
            string followeeUserId)
        {
            this.FollowerUserId = followerUserId ?? throw new global::System.ArgumentNullException(nameof(followerUserId));
            this.FolloweeUserId = followeeUserId ?? throw new global::System.ArgumentNullException(nameof(followeeUserId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowNotificationActionData" /> class.
        /// </summary>
        public FollowNotificationActionData()
        {
        }

    }
}