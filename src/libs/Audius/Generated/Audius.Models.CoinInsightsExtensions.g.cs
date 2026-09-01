
#nullable enable

namespace Audius
{
    /// <summary>
    /// Token metadata and links
    /// </summary>
    public sealed partial class CoinInsightsExtensions
    {
        /// <summary>
        /// CoinGecko ID<br/>
        /// Example: bonk
        /// </summary>
        /// <example>bonk</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("coingeckoId")]
        public string? CoingeckoId { get; set; }

        /// <summary>
        /// Token description<br/>
        /// Example: The Official Bonk Inu token
        /// </summary>
        /// <example>The Official Bonk Inu token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Twitter URL<br/>
        /// Example: https://twitter.com/bonk_inu
        /// </summary>
        /// <example>https://twitter.com/bonk_inu</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter")]
        public string? Twitter { get; set; }

        /// <summary>
        /// Website URL<br/>
        /// Example: https://www.bonkcoin.com/
        /// </summary>
        /// <example>https://www.bonkcoin.com/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Discord invite URL<br/>
        /// Example: https://discord.gg/ubqvDDFUhf
        /// </summary>
        /// <example>https://discord.gg/ubqvDDFUhf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("discord")]
        public string? Discord { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoinInsightsExtensions" /> class.
        /// </summary>
        /// <param name="coingeckoId">
        /// CoinGecko ID<br/>
        /// Example: bonk
        /// </param>
        /// <param name="description">
        /// Token description<br/>
        /// Example: The Official Bonk Inu token
        /// </param>
        /// <param name="twitter">
        /// Twitter URL<br/>
        /// Example: https://twitter.com/bonk_inu
        /// </param>
        /// <param name="website">
        /// Website URL<br/>
        /// Example: https://www.bonkcoin.com/
        /// </param>
        /// <param name="discord">
        /// Discord invite URL<br/>
        /// Example: https://discord.gg/ubqvDDFUhf
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoinInsightsExtensions(
            string? coingeckoId,
            string? description,
            string? twitter,
            string? website,
            string? discord)
        {
            this.CoingeckoId = coingeckoId;
            this.Description = description;
            this.Twitter = twitter;
            this.Website = website;
            this.Discord = discord;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoinInsightsExtensions" /> class.
        /// </summary>
        public CoinInsightsExtensions()
        {
        }

    }
}