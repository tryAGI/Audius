
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreatePlaylistRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Genre), TypeInfoPropertyName = "Genre2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Mood), TypeInfoPropertyName = "Mood2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Track>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Track))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingPlaylistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Playlist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Playlist))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.WriteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccessInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAccessInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FavoriteRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserArtistCoinBadge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoverPhoto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ProfilePicture))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibrary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreatePlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdatePlaylistRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackArtwork))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixParent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AlbumBacklink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoverArt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UrlWithMirrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedAccessGate), TypeInfoPropertyName = "ExtendedAccessGate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedTokenGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Remix>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Remix))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedPurchaseGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PaymentSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PaymentSplit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedUsdcGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ExtendedPaymentSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedPaymentSplit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchPlaylistsSortMethod), TypeInfoPropertyName = "SearchPlaylistsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPlaylistsNewReleasesType), TypeInfoPropertyName = "GetPlaylistsNewReleasesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsTime), TypeInfoPropertyName = "GetTrendingPlaylistsTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsType), TypeInfoPropertyName = "GetTrendingPlaylistsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsWithVersionTime), TypeInfoPropertyName = "GetTrendingPlaylistsWithVersionTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Genre?), TypeInfoPropertyName = "NullableGenre2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Mood?), TypeInfoPropertyName = "NullableMood2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccessGate?), TypeInfoPropertyName = "NullableAccessGate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedAccessGate?), TypeInfoPropertyName = "NullableExtendedAccessGate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchPlaylistsSortMethod?), TypeInfoPropertyName = "NullableSearchPlaylistsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPlaylistsNewReleasesType?), TypeInfoPropertyName = "NullableGetPlaylistsNewReleasesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsTime?), TypeInfoPropertyName = "NullableGetTrendingPlaylistsTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsType?), TypeInfoPropertyName = "NullableGetTrendingPlaylistsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsWithVersionTime?), TypeInfoPropertyName = "NullableGetTrendingPlaylistsWithVersionTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PlaylistAddedTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.DdexResourceContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Track>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Playlist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Repost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Favorite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Remix>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PaymentSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ExtendedPaymentSplit>))]
    internal sealed partial class PlaylistsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlaylistsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PlaylistsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PlaylistsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Audius.JsonConverters.ExtendedAccessGateJsonConverter());
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
                    typeToConvert == typeof(global::Audius.Genre)

                    || typeToConvert == typeof(global::Audius.Genre?)

                    || typeToConvert == typeof(global::Audius.Mood)

                    || typeToConvert == typeof(global::Audius.Mood?)

                    || typeToConvert == typeof(global::Audius.SearchPlaylistsSortMethod)

                    || typeToConvert == typeof(global::Audius.SearchPlaylistsSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetPlaylistsNewReleasesType)

                    || typeToConvert == typeof(global::Audius.GetPlaylistsNewReleasesType?)

                    || typeToConvert == typeof(global::Audius.GetTrendingPlaylistsTime)

                    || typeToConvert == typeof(global::Audius.GetTrendingPlaylistsTime?)

                    || typeToConvert == typeof(global::Audius.GetTrendingPlaylistsType)

                    || typeToConvert == typeof(global::Audius.GetTrendingPlaylistsType?)

                    || typeToConvert == typeof(global::Audius.GetTrendingPlaylistsWithVersionTime)

                    || typeToConvert == typeof(global::Audius.GetTrendingPlaylistsWithVersionTime?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Audius.Genre))
                {
                    return new global::Audius.JsonConverters.GenreJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.Genre?))
                {
                    return new global::Audius.JsonConverters.GenreNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.Mood))
                {
                    return new global::Audius.JsonConverters.MoodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.Mood?))
                {
                    return new global::Audius.JsonConverters.MoodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchPlaylistsSortMethod))
                {
                    return new global::Audius.JsonConverters.SearchPlaylistsSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchPlaylistsSortMethod?))
                {
                    return new global::Audius.JsonConverters.SearchPlaylistsSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetPlaylistsNewReleasesType))
                {
                    return new global::Audius.JsonConverters.GetPlaylistsNewReleasesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetPlaylistsNewReleasesType?))
                {
                    return new global::Audius.JsonConverters.GetPlaylistsNewReleasesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingPlaylistsTime))
                {
                    return new global::Audius.JsonConverters.GetTrendingPlaylistsTimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingPlaylistsTime?))
                {
                    return new global::Audius.JsonConverters.GetTrendingPlaylistsTimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingPlaylistsType))
                {
                    return new global::Audius.JsonConverters.GetTrendingPlaylistsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingPlaylistsType?))
                {
                    return new global::Audius.JsonConverters.GetTrendingPlaylistsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingPlaylistsWithVersionTime))
                {
                    return new global::Audius.JsonConverters.GetTrendingPlaylistsWithVersionTimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingPlaylistsWithVersionTime?))
                {
                    return new global::Audius.JsonConverters.GetTrendingPlaylistsWithVersionTimeNullableJsonConverter();
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
                    0 => new PlaylistsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}