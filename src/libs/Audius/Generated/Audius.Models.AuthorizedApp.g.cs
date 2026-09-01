
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthorizedApp
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantor_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GrantorUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GrantCreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GrantUpdatedAt { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedApp" /> class.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="name"></param>
        /// <param name="grantorUserId"></param>
        /// <param name="grantCreatedAt"></param>
        /// <param name="grantUpdatedAt"></param>
        /// <param name="description"></param>
        /// <param name="imageUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorizedApp(
            string address,
            string name,
            string grantorUserId,
            string grantCreatedAt,
            string grantUpdatedAt,
            string? description,
            string? imageUrl)
        {
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ImageUrl = imageUrl;
            this.GrantorUserId = grantorUserId ?? throw new global::System.ArgumentNullException(nameof(grantorUserId));
            this.GrantCreatedAt = grantCreatedAt ?? throw new global::System.ArgumentNullException(nameof(grantCreatedAt));
            this.GrantUpdatedAt = grantUpdatedAt ?? throw new global::System.ArgumentNullException(nameof(grantUpdatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedApp" /> class.
        /// </summary>
        public AuthorizedApp()
        {
        }

    }
}