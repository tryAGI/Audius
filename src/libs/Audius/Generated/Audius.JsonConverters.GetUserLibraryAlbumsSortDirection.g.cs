#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetUserLibraryAlbumsSortDirectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.GetUserLibraryAlbumsSortDirection>
    {
        /// <inheritdoc />
        public override global::Audius.GetUserLibraryAlbumsSortDirection Read(
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
                        return global::Audius.GetUserLibraryAlbumsSortDirectionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.GetUserLibraryAlbumsSortDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.GetUserLibraryAlbumsSortDirection);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.GetUserLibraryAlbumsSortDirection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Audius.GetUserLibraryAlbumsSortDirectionExtensions.ToValueString(value));
        }
    }
}
