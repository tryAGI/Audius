
#nullable enable

namespace Audius
{
    /// <summary>
    /// Optional metadata for favorite/save operations
    /// </summary>
    public sealed partial class FavoriteRequestBody
    {
        /// <summary>
        /// Set to true when favoriting a reposted item (used for notifications)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_save_of_repost")]
        public bool? IsSaveOfRepost { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteRequestBody" /> class.
        /// </summary>
        /// <param name="isSaveOfRepost">
        /// Set to true when favoriting a reposted item (used for notifications)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FavoriteRequestBody(
            bool? isSaveOfRepost)
        {
            this.IsSaveOfRepost = isSaveOfRepost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteRequestBody" /> class.
        /// </summary>
        public FavoriteRequestBody()
        {
        }

    }
}