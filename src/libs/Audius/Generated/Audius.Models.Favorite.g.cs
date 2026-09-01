
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Favorite
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favorite_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FavoriteItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favorite_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FavoriteType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Favorite" /> class.
        /// </summary>
        /// <param name="favoriteItemId"></param>
        /// <param name="favoriteType"></param>
        /// <param name="userId"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Favorite(
            string favoriteItemId,
            string favoriteType,
            string userId,
            string createdAt)
        {
            this.FavoriteItemId = favoriteItemId ?? throw new global::System.ArgumentNullException(nameof(favoriteItemId));
            this.FavoriteType = favoriteType ?? throw new global::System.ArgumentNullException(nameof(favoriteType));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Favorite" /> class.
        /// </summary>
        public Favorite()
        {
        }

    }
}