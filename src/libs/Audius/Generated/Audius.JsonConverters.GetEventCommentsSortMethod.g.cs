#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetEventCommentsSortMethodJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.GetEventCommentsSortMethod>
    {
        /// <inheritdoc />
        public override global::Audius.GetEventCommentsSortMethod Read(
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
                        return global::Audius.GetEventCommentsSortMethodExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.GetEventCommentsSortMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.GetEventCommentsSortMethod);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.GetEventCommentsSortMethod value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Audius.GetEventCommentsSortMethodExtensions.ToValueString(value));
        }
    }
}
