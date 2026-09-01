
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectedWallets
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("erc_wallets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ErcWallets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spl_wallets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SplWallets { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectedWallets" /> class.
        /// </summary>
        /// <param name="ercWallets"></param>
        /// <param name="splWallets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectedWallets(
            global::System.Collections.Generic.IList<string> ercWallets,
            global::System.Collections.Generic.IList<string> splWallets)
        {
            this.ErcWallets = ercWallets ?? throw new global::System.ArgumentNullException(nameof(ercWallets));
            this.SplWallets = splWallets ?? throw new global::System.ArgumentNullException(nameof(splWallets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectedWallets" /> class.
        /// </summary>
        public ConnectedWallets()
        {
        }

    }
}