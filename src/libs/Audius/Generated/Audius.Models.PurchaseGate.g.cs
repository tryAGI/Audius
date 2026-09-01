
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PurchaseGate
    {
        /// <summary>
        /// Must pay the total price and split to the given addresses to unlock
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usdc_purchase")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.UsdcGate UsdcPurchase { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseGate" /> class.
        /// </summary>
        /// <param name="usdcPurchase">
        /// Must pay the total price and split to the given addresses to unlock
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PurchaseGate(
            global::Audius.UsdcGate usdcPurchase)
        {
            this.UsdcPurchase = usdcPurchase ?? throw new global::System.ArgumentNullException(nameof(usdcPurchase));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseGate" /> class.
        /// </summary>
        public PurchaseGate()
        {
        }

    }
}