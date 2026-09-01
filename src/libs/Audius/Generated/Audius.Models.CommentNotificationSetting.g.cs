
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CommentNotificationSetting
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_muted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsMuted { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentNotificationSetting" /> class.
        /// </summary>
        /// <param name="isMuted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommentNotificationSetting(
            bool isMuted)
        {
            this.IsMuted = isMuted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentNotificationSetting" /> class.
        /// </summary>
        public CommentNotificationSetting()
        {
        }

    }
}