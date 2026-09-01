
#nullable enable

namespace Audius
{
    /// <summary>
    /// ## Overview<br/>
    /// The Audius API provides REST access to the world's largest open music catalog, built on the [Open Audio Protocol](https://openaudio.org). Use it to query and stream tracks, users, playlists, and more—perfect for building music players, discovery apps, and audio-native products.<br/>
    /// ## Key Capabilities<br/>
    /// - **Users** — Profiles, followers, following, search<br/>
    /// - **Tracks** — Search, trending, stream, favorites, reposts<br/>
    /// - **Playlists** — Create, update, browse, curate<br/>
    /// - **Resolve** — Look up content by Audius canonical URLs (e.g. `audius.co/artist/...`)<br/>
    /// - **Explore** — Trending content, charts, discovery<br/>
    /// - **Comments, Tips, Rewards** — Social features and engagement<br/>
    /// ## Authentication<br/>
    /// - **Read-only** — Most endpoints work without credentials. Use an API key for higher rate limits.<br/>
    /// - **Writes** — Upload, favorite, repost, and other mutations require an API key and secret. Get keys at [api.audius.co/plans](https://api.audius.co/plans) or [audius.co/settings](https://audius.co/settings).<br/>
    /// ## Resources<br/>
    /// - [API Docs](https://docs.audius.co/api) — Full reference and guides<br/>
    /// - [API Plans](https://api.audius.co/plans) — Get API keys (free tier available)<br/>
    /// - [Log in with Audius](https://docs.audius.co/developers/guides/log-in-with-audius) — OAuth for user actions<br/>
    /// - [JavaScript SDK](https://www.npmjs.com/package/@audius/sdk) — `@audius/sdk` for Node and browser<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IAudiusClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Audius.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Audius.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Challenge related operations.
        /// </summary>
        public ChallengesClient Challenges { get; }

        /// <summary>
        ///
        /// </summary>
        public CidDataClient CidData { get; }

        /// <summary>
        ///
        /// </summary>
        public CoinsClient Coins { get; }

        /// <summary>
        /// Comment related operations.
        /// </summary>
        public CommentsClient Comments { get; }

        /// <summary>
        /// Protocol dashboard wallet users related operations.
        /// </summary>
        public DashboardWalletUsersClient DashboardWalletUsers { get; }

        /// <summary>
        /// Developer app related operations.
        /// </summary>
        public DeveloperAppsClient DeveloperApps { get; }

        /// <summary>
        /// Events related operations.
        /// </summary>
        public EventsClient Events { get; }

        /// <summary>
        /// Explore related operations.
        /// </summary>
        public ExploreClient Explore { get; }

        /// <summary>
        ///
        /// </summary>
        public FanClubClient FanClub { get; }

        /// <summary>
        ///
        /// </summary>
        public NotificationsClient Notifications { get; }

        /// <summary>
        /// Playlist related operations.
        /// </summary>
        public PlaylistsClient Playlists { get; }

        /// <summary>
        /// Prize claiming related operations.
        /// </summary>
        public PrizesClient Prizes { get; }

        /// <summary>
        ///
        /// </summary>
        public ReactionsClient Reactions { get; }

        /// <summary>
        /// Audius Canonical URL resolver.
        /// </summary>
        public ResolveClient Resolve { get; }

        /// <summary>
        /// Rewards related operations.
        /// </summary>
        public RewardsClient Rewards { get; }

        /// <summary>
        ///
        /// </summary>
        public SearchClient Search { get; }

        /// <summary>
        /// Tip related operations.
        /// </summary>
        public TipsClient Tips { get; }

        /// <summary>
        /// Track related operations.
        /// </summary>
        public TracksClient Tracks { get; }

        /// <summary>
        /// User related operations.
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        ///
        /// </summary>
        public WalletClient Wallet { get; }

    }
}