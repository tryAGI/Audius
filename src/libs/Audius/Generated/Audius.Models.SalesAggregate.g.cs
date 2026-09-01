
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SalesAggregate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchase_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PurchaseCount { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesAggregate" /> class.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="contentId"></param>
        /// <param name="purchaseCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SalesAggregate(
            string contentType,
            string contentId,
            int purchaseCount)
        {
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.ContentId = contentId ?? throw new global::System.ArgumentNullException(nameof(contentId));
            this.PurchaseCount = purchaseCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesAggregate" /> class.
        /// </summary>
        public SalesAggregate()
        {
        }

    }
}