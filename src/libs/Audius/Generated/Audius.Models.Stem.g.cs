
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Stem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocknumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Blocknumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orig_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrigFilename { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Stem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="parentId"></param>
        /// <param name="category"></param>
        /// <param name="cid"></param>
        /// <param name="userId"></param>
        /// <param name="blocknumber"></param>
        /// <param name="origFilename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Stem(
            string id,
            string parentId,
            string category,
            string cid,
            string userId,
            int blocknumber,
            string origFilename)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ParentId = parentId ?? throw new global::System.ArgumentNullException(nameof(parentId));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Cid = cid ?? throw new global::System.ArgumentNullException(nameof(cid));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Blocknumber = blocknumber;
            this.OrigFilename = origFilename ?? throw new global::System.ArgumentNullException(nameof(origFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stem" /> class.
        /// </summary>
        public Stem()
        {
        }

    }
}