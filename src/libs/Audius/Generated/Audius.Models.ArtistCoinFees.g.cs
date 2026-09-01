
#nullable enable

namespace Audius
{
    /// <summary>
    /// Artist coin fee info (unclaimed/total)
    /// </summary>
    public sealed partial class ArtistCoinFees
    {
        /// <summary>
        /// Unclaimed fees
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unclaimed_fees")]
        public double? UnclaimedFees { get; set; }

        /// <summary>
        /// Total fees
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_fees")]
        public double? TotalFees { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistCoinFees" /> class.
        /// </summary>
        /// <param name="unclaimedFees">
        /// Unclaimed fees
        /// </param>
        /// <param name="totalFees">
        /// Total fees
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtistCoinFees(
            double? unclaimedFees,
            double? totalFees)
        {
            this.UnclaimedFees = unclaimedFees;
            this.TotalFees = totalFees;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistCoinFees" /> class.
        /// </summary>
        public ArtistCoinFees()
        {
        }

    }
}