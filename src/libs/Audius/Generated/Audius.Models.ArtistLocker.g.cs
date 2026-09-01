
#nullable enable

namespace Audius
{
    /// <summary>
    /// Artist locker balance and claimable info for the coin
    /// </summary>
    public sealed partial class ArtistLocker
    {
        /// <summary>
        /// Locker contract/pool address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Locked amount
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        public double? Locked { get; set; }

        /// <summary>
        /// Unlocked amount
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unlocked")]
        public double? Unlocked { get; set; }

        /// <summary>
        /// Claimable amount
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimable")]
        public double? Claimable { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistLocker" /> class.
        /// </summary>
        /// <param name="address">
        /// Locker contract/pool address
        /// </param>
        /// <param name="locked">
        /// Locked amount
        /// </param>
        /// <param name="unlocked">
        /// Unlocked amount
        /// </param>
        /// <param name="claimable">
        /// Claimable amount
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtistLocker(
            string? address,
            double? locked,
            double? unlocked,
            double? claimable)
        {
            this.Address = address;
            this.Locked = locked;
            this.Unlocked = unlocked;
            this.Claimable = claimable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistLocker" /> class.
        /// </summary>
        public ArtistLocker()
        {
        }

    }
}