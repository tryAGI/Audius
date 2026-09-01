#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class PlaylistLibraryExplorePlaylistIdentifierTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.PlaylistLibraryExplorePlaylistIdentifierType>
    {
        /// <inheritdoc />
        public override global::Audius.PlaylistLibraryExplorePlaylistIdentifierType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Audius.PlaylistLibraryExplorePlaylistIdentifierTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.PlaylistLibraryExplorePlaylistIdentifierType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.PlaylistLibraryExplorePlaylistIdentifierType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.PlaylistLibraryExplorePlaylistIdentifierType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Audius.PlaylistLibraryExplorePlaylistIdentifierTypeExtensions.ToValueString(value));
        }
    }
}
