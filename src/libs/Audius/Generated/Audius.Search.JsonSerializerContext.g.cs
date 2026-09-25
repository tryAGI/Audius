
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.VersionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PlaylistAddedTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistAddedTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccessGate), TypeInfoPropertyName = "AccessGate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DdexResourceContributor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DdexCopyright))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DdexRightsController))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Track>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Track))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FieldVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.StemParent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TipGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchaseGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TokenGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistArtwork))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Access))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Repost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Repost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Favorite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Favorite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SearchTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SearchPlaylist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchPlaylist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserArtistCoinBadge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoverPhoto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ProfilePicture))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibrary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackArtwork))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixParent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AlbumBacklink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoverArt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UrlWithMirrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedTokenGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Remix>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Remix))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PaymentSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PaymentSplit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteKind), TypeInfoPropertyName = "SearchAutocompleteKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteSortMethod), TypeInfoPropertyName = "SearchAutocompleteSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchKind), TypeInfoPropertyName = "SearchKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchSortMethod), TypeInfoPropertyName = "SearchSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTagsKind), TypeInfoPropertyName = "SearchTagsKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTagsSortMethod), TypeInfoPropertyName = "SearchTagsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccessGate?), TypeInfoPropertyName = "NullableAccessGate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteKind?), TypeInfoPropertyName = "NullableSearchAutocompleteKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteSortMethod?), TypeInfoPropertyName = "NullableSearchAutocompleteSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchKind?), TypeInfoPropertyName = "NullableSearchKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchSortMethod?), TypeInfoPropertyName = "NullableSearchSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTagsKind?), TypeInfoPropertyName = "NullableSearchTagsKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTagsSortMethod?), TypeInfoPropertyName = "NullableSearchTagsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PlaylistAddedTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.DdexResourceContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Track>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Repost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Favorite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SearchTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SearchPlaylist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Remix>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PaymentSplit>))]
    internal sealed partial class SearchSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SearchSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SearchSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Audius.JsonConverters.AccessGateJsonConverter());
            options.Converters.Add(new global::Audius.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Audius.SearchAutocompleteKind)

                    || typeToConvert == typeof(global::Audius.SearchAutocompleteKind?)

                    || typeToConvert == typeof(global::Audius.SearchAutocompleteSortMethod)

                    || typeToConvert == typeof(global::Audius.SearchAutocompleteSortMethod?)

                    || typeToConvert == typeof(global::Audius.SearchKind)

                    || typeToConvert == typeof(global::Audius.SearchKind?)

                    || typeToConvert == typeof(global::Audius.SearchSortMethod)

                    || typeToConvert == typeof(global::Audius.SearchSortMethod?)

                    || typeToConvert == typeof(global::Audius.SearchTagsKind)

                    || typeToConvert == typeof(global::Audius.SearchTagsKind?)

                    || typeToConvert == typeof(global::Audius.SearchTagsSortMethod)

                    || typeToConvert == typeof(global::Audius.SearchTagsSortMethod?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Audius.SearchAutocompleteKind))
                {
                    return new global::Audius.JsonConverters.SearchAutocompleteKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchAutocompleteKind?))
                {
                    return new global::Audius.JsonConverters.SearchAutocompleteKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchAutocompleteSortMethod))
                {
                    return new global::Audius.JsonConverters.SearchAutocompleteSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchAutocompleteSortMethod?))
                {
                    return new global::Audius.JsonConverters.SearchAutocompleteSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchKind))
                {
                    return new global::Audius.JsonConverters.SearchKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchKind?))
                {
                    return new global::Audius.JsonConverters.SearchKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchSortMethod))
                {
                    return new global::Audius.JsonConverters.SearchSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchSortMethod?))
                {
                    return new global::Audius.JsonConverters.SearchSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchTagsKind))
                {
                    return new global::Audius.JsonConverters.SearchTagsKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchTagsKind?))
                {
                    return new global::Audius.JsonConverters.SearchTagsKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchTagsSortMethod))
                {
                    return new global::Audius.JsonConverters.SearchTagsSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchTagsSortMethod?))
                {
                    return new global::Audius.JsonConverters.SearchTagsSortMethodNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SearchSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}