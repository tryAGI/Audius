
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtendedUsdcGate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Price { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.ExtendedPaymentSplit> Splits { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedUsdcGate" /> class.
        /// </summary>
        /// <param name="price"></param>
        /// <param name="splits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtendedUsdcGate(
            int price,
            global::System.Collections.Generic.IList<global::Audius.ExtendedPaymentSplit> splits)
        {
            this.Price = price;
            this.Splits = splits ?? throw new global::System.ArgumentNullException(nameof(splits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedUsdcGate" /> class.
        /// </summary>
        public ExtendedUsdcGate()
        {
        }

    }
}