
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsdcGate
    {
        /// <summary>
        /// The price in USDC needed to unlock
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Price { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.PaymentSplit> Splits { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsdcGate" /> class.
        /// </summary>
        /// <param name="price">
        /// The price in USDC needed to unlock
        /// </param>
        /// <param name="splits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsdcGate(
            int price,
            global::System.Collections.Generic.IList<global::Audius.PaymentSplit> splits)
        {
            this.Price = price;
            this.Splits = splits ?? throw new global::System.ArgumentNullException(nameof(splits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsdcGate" /> class.
        /// </summary>
        public UsdcGate()
        {
        }

    }
}