
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CidData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectibles")]
        public object? Collectibles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("associated_sol_wallets")]
        public object? AssociatedSolWallets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("associated_wallets")]
        public object? AssociatedWallets { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CidData" /> class.
        /// </summary>
        /// <param name="collectibles"></param>
        /// <param name="associatedSolWallets"></param>
        /// <param name="associatedWallets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CidData(
            object? collectibles,
            object? associatedSolWallets,
            object? associatedWallets)
        {
            this.Collectibles = collectibles;
            this.AssociatedSolWallets = associatedSolWallets;
            this.AssociatedWallets = associatedWallets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CidData" /> class.
        /// </summary>
        public CidData()
        {
        }

    }
}