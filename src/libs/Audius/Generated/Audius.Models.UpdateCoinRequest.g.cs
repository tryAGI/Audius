
#nullable enable

namespace Audius
{
    /// <summary>
    /// Request body for updating coin information
    /// </summary>
    public sealed partial class UpdateCoinRequest
    {
        /// <summary>
        /// The description of the coin (max 2500 characters)<br/>
        /// Example: Updated description for the bear token
        /// </summary>
        /// <example>Updated description for the bear token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL for the coin's banner image<br/>
        /// Example: https://example.com/banner.png
        /// </summary>
        /// <example>https://example.com/banner.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("banner_image_url")]
        public string? BannerImageUrl { get; set; }

        /// <summary>
        /// Generic link URL for the coin<br/>
        /// Example: https://x.com/bear_token
        /// </summary>
        /// <example>https://x.com/bear_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_1")]
        public string? Link1 { get; set; }

        /// <summary>
        /// Generic link URL for the coin<br/>
        /// Example: https://instagram.com/bear_token
        /// </summary>
        /// <example>https://instagram.com/bear_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_2")]
        public string? Link2 { get; set; }

        /// <summary>
        /// Generic link URL for the coin<br/>
        /// Example: https://tiktok.com/@bear_token
        /// </summary>
        /// <example>https://tiktok.com/@bear_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_3")]
        public string? Link3 { get; set; }

        /// <summary>
        /// Generic link URL for the coin<br/>
        /// Example: https://bear-token.com
        /// </summary>
        /// <example>https://bear-token.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_4")]
        public string? Link4 { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCoinRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the coin (max 2500 characters)<br/>
        /// Example: Updated description for the bear token
        /// </param>
        /// <param name="bannerImageUrl">
        /// URL for the coin's banner image<br/>
        /// Example: https://example.com/banner.png
        /// </param>
        /// <param name="link1">
        /// Generic link URL for the coin<br/>
        /// Example: https://x.com/bear_token
        /// </param>
        /// <param name="link2">
        /// Generic link URL for the coin<br/>
        /// Example: https://instagram.com/bear_token
        /// </param>
        /// <param name="link3">
        /// Generic link URL for the coin<br/>
        /// Example: https://tiktok.com/@bear_token
        /// </param>
        /// <param name="link4">
        /// Generic link URL for the coin<br/>
        /// Example: https://bear-token.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCoinRequest(
            string? description,
            string? bannerImageUrl,
            string? link1,
            string? link2,
            string? link3,
            string? link4)
        {
            this.Description = description;
            this.BannerImageUrl = bannerImageUrl;
            this.Link1 = link1;
            this.Link2 = link2;
            this.Link3 = link3;
            this.Link4 = link4;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCoinRequest" /> class.
        /// </summary>
        public UpdateCoinRequest()
        {
        }

    }
}