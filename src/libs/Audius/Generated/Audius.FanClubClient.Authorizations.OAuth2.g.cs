
#nullable enable

namespace Audius
{
    using OAuth2DeviceAuthorizationResponse = global::Audius.AudiusClient.OAuth2DeviceAuthorizationResponse;
    using OAuth2Token = global::Audius.AudiusClient.OAuth2Token;
    using IOAuth2TokenStore = global::Audius.AudiusClient.IOAuth2TokenStore;
    using AutoSDKOAuth2Helpers = global::Audius.AudiusClient.AutoSDKOAuth2Helpers;

    public sealed partial class FanClubClient
    {
        /// <summary>
        /// Known OAuth2 scopes.
        /// </summary>
        public enum OAuth2Scope
        {
            /// <summary>
            /// OAuth2 scope <c>read</c>.
            /// </summary>
            Read,            /// <summary>
            /// OAuth2 scope <c>write</c>.
            /// </summary>
            Write,
        }
        /// <summary>
        /// Gets the OAuth2 metadata URL declared by the security scheme, if any.
        /// </summary>
        public string? OAuth2MetadataUrl => string.IsNullOrWhiteSpace("")
            ? null
            : "";

        /// <summary>
        /// Gets a value indicating whether the OAuth2 security scheme is deprecated.
        /// </summary>
        public bool IsOAuth2Deprecated => false;
        /// <summary>
        /// Gets or sets the OAuth2 token store.
        /// </summary>
        public IOAuth2TokenStore OAuth2TokenStore
        {
            get => AutoSDKOAuth2State.TokenStore;
            set
            {
                value = value ?? throw new global::System.ArgumentNullException(nameof(value));

                var token = AutoSDKOAuth2State.GetToken();
                AutoSDKOAuth2State.TokenStore = value;
                if (token is not null)
                {
                    AutoSDKOAuth2State.SetToken(token);
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether OAuth2 tokens should be refreshed automatically.
        /// </summary>
        public bool AutoRefreshOAuth2Tokens
        {
            get => AutoSDKOAuth2State.AutoRefreshTokens;
            set => AutoSDKOAuth2State.AutoRefreshTokens = value;
        }

        /// <summary>
        /// Gets or sets the clock skew used when checking OAuth2 token expiration.
        /// </summary>
        public global::System.TimeSpan OAuth2RefreshClockSkew
        {
            get => AutoSDKOAuth2State.RefreshClockSkew;
            set
            {
                if (value < global::System.TimeSpan.Zero)
                {
                    throw new global::System.ArgumentOutOfRangeException(nameof(value));
                }

                AutoSDKOAuth2State.RefreshClockSkew = value;
            }
        }

        /// <summary>
        /// Configures the OAuth2 token refresh callback.
        /// </summary>
        /// <param name="refreshTokenAsync"></param>
        public void ConfigureOAuth2TokenRefresh(
            global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<OAuth2Token>> refreshTokenAsync)
        {
            AutoSDKOAuth2State.ConfigureRefresh(refreshTokenAsync);
        }

        /// <summary>
        /// Gets the currently stored OAuth2 token.
        /// </summary>
        /// <returns>The stored OAuth2 token, if present.</returns>
        public OAuth2Token? GetOAuth2Token()
        {
            return AutoSDKOAuth2State.GetToken();
        }

        /// <summary>
        /// Clears the stored OAuth2 token.
        /// </summary>
        public void ClearOAuth2Token()
        {
            AutoSDKOAuth2State.SetToken(null);
            AutoSDKOAuth2Helpers.SetAuthorization(Authorizations, null);
        }

        /// <summary>
        /// Authorize using an OAuth2 access token.
        /// </summary>
        /// <param name="accessToken"></param>

        public void AuthorizeUsingOAuth2(
            string accessToken)
        {
            accessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));

            AuthorizeUsingOAuth2(new OAuth2Token
            {
                AccessToken = accessToken,
                TokenType = "Bearer",
            });
        }

        /// <summary>
        /// Authorize using an OAuth2 token.
        /// </summary>
        /// <param name="token"></param>

        public void AuthorizeUsingOAuth2(
            OAuth2Token token)
        {
            token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            if (string.IsNullOrWhiteSpace(token.AccessToken))
            {
                throw new global::System.ArgumentException("Access token cannot be empty.", nameof(token));
            }
            if (string.IsNullOrWhiteSpace(token.TokenType))
            {
                token.TokenType = "Bearer";
            }

            var storedToken = token.Clone();
            AutoSDKOAuth2State.SetToken(storedToken);
            AutoSDKOAuth2Helpers.SetAuthorization(Authorizations, storedToken);
        }


        private async global::System.Threading.Tasks.Task<OAuth2Token> ExchangeOAuth2TokenAsync(
            global::System.Uri tokenUrl,
            global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>> body,
            string? requestedScope = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            tokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            body = body ?? throw new global::System.ArgumentNullException(nameof(body));

            using var response = await HttpClient.PostAsync(
                requestUri: tokenUrl,
                content: new global::System.Net.Http.FormUrlEncodedContent(body),
                cancellationToken: cancellationToken).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            using var jsonDocument = global::System.Text.Json.JsonDocument.Parse(json);
            if (!jsonDocument.RootElement.TryGetProperty("access_token", out var accessTokenElement))
            {
                throw new global::System.InvalidOperationException("access_token was not present in the token response.");
            }

            var accessToken = accessTokenElement.GetString();
            if (string.IsNullOrWhiteSpace(accessToken))
            {
                throw new global::System.InvalidOperationException("access_token was empty in the token response.");
            }

            string? tokenType = null;
            if (jsonDocument.RootElement.TryGetProperty("token_type", out var tokenTypeElement))
            {
                tokenType = tokenTypeElement.GetString();
            }

            string? refreshToken = null;
            if (jsonDocument.RootElement.TryGetProperty("refresh_token", out var refreshTokenElement))
            {
                refreshToken = refreshTokenElement.GetString();
            }

            string? scope = null;
            if (jsonDocument.RootElement.TryGetProperty("scope", out var scopeElement))
            {
                scope = scopeElement.GetString();
            }

            long? expiresIn = null;
            if (jsonDocument.RootElement.TryGetProperty("expires_in", out var expiresInElement))
            {
                if (expiresInElement.ValueKind == global::System.Text.Json.JsonValueKind.Number &&
                    expiresInElement.TryGetInt64(out var expiresInValue))
                {
                    expiresIn = expiresInValue;
                }
                else if (expiresInElement.ValueKind == global::System.Text.Json.JsonValueKind.String &&
                         long.TryParse(expiresInElement.GetString(), out expiresInValue))
                {
                    expiresIn = expiresInValue;
                }
            }

            var token = new OAuth2Token
            {
                AccessToken = accessToken,
                TokenType = string.IsNullOrWhiteSpace(tokenType) ? "Bearer" : tokenType,
                RefreshToken = refreshToken,
                Scope = string.IsNullOrWhiteSpace(scope) ? requestedScope : scope,
                ExpiresAt = expiresIn.HasValue
                    ? global::System.DateTimeOffset.UtcNow.AddSeconds(expiresIn.Value)
                    : (global::System.DateTimeOffset?)null,
            };

            return token;
        }
        /// <summary>
        /// Creates the OAuth2 authorization URL for the authorization code flow using typed scopes.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="scopes"></param>
        /// <param name="state"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <returns>The authorization URL.</returns>

        public string GetOAuth2AuthorizationUrl(
            string clientId,
            string redirectUri,
            global::System.Collections.Generic.IEnumerable<OAuth2Scope>? scopes,
            string? state = null,
            string? codeChallenge = null,
            string codeChallengeMethod = "S256")
        {
            return GetOAuth2AuthorizationUrl(
                clientId: clientId,
                redirectUri: redirectUri,
                scopes: scopes is null
                    ? null
                    : global::System.Linq.Enumerable.Select(scopes, static x => ToOAuth2ScopeValue(x)),
                state: state,
                codeChallenge: codeChallenge,
                codeChallengeMethod: codeChallengeMethod);
        }

        /// <summary>
        /// Creates the OAuth2 authorization URL for the authorization code flow.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="scopes"></param>
        /// <param name="state"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <returns>The authorization URL.</returns>

        public string GetOAuth2AuthorizationUrl(
            string clientId,
            string redirectUri,
            global::System.Collections.Generic.IEnumerable<string>? scopes = null,
            string? state = null,
            string? codeChallenge = null,
            string codeChallengeMethod = "S256")
        {
            clientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            redirectUri = redirectUri ?? throw new global::System.ArgumentNullException(nameof(redirectUri));
            codeChallengeMethod = codeChallengeMethod ?? throw new global::System.ArgumentNullException(nameof(codeChallengeMethod));

            var parameters = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
            {
                new global::System.Collections.Generic.KeyValuePair<string, string>("response_type", "code"),
                new global::System.Collections.Generic.KeyValuePair<string, string>("client_id", clientId),
                new global::System.Collections.Generic.KeyValuePair<string, string>("redirect_uri", redirectUri),
            };
            var scopeValue = scopes is null
                ? string.Empty
                : string.Join(" ", global::System.Linq.Enumerable.Where(scopes, static x => !string.IsNullOrWhiteSpace(x)));
            if (!string.IsNullOrWhiteSpace(scopeValue))
            {
                parameters.Add(new global::System.Collections.Generic.KeyValuePair<string, string>("scope", scopeValue));
            }
            if (!string.IsNullOrWhiteSpace(state))
            {
                parameters.Add(new global::System.Collections.Generic.KeyValuePair<string, string>("state", state));
            }
            if (!string.IsNullOrWhiteSpace(codeChallenge))
            {
                parameters.Add(new global::System.Collections.Generic.KeyValuePair<string, string>("code_challenge", codeChallenge));
                parameters.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                    "code_challenge_method",
                    string.IsNullOrWhiteSpace(codeChallengeMethod) ? "S256" : codeChallengeMethod));
            }

            var query = string.Join(
                "&",
                global::System.Linq.Enumerable.Select(
                    parameters,
                    static x => global::System.Uri.EscapeDataString(x.Key) + "=" + global::System.Uri.EscapeDataString(x.Value) ));
            var separator = "/v1/oauth/authorize".Contains("?", global::System.StringComparison.Ordinal) ? "&" : "?";
            return $"/v1/oauth/authorize{separator}{query}";
        }

        /// <summary>
        /// Exchanges an OAuth2 authorization code for a token.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="code"></param>
        /// <param name="redirectUri"></param>
        /// <param name="clientSecret"></param>
        /// <param name="codeVerifier"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>The OAuth2 token.</returns>

        public async global::System.Threading.Tasks.Task<OAuth2Token> ExchangeOAuth2CodeForTokenAsync(
            string clientId,
            string code,
            string redirectUri,
            string? clientSecret = null,
            string? codeVerifier = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            clientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            redirectUri = redirectUri ?? throw new global::System.ArgumentNullException(nameof(redirectUri));

            var body = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
            {
                new global::System.Collections.Generic.KeyValuePair<string, string>("grant_type", "authorization_code"),
                new global::System.Collections.Generic.KeyValuePair<string, string>("client_id", clientId),
                new global::System.Collections.Generic.KeyValuePair<string, string>("code", code),
                new global::System.Collections.Generic.KeyValuePair<string, string>("redirect_uri", redirectUri),
            };
            if (!string.IsNullOrWhiteSpace(clientSecret))
            {
                body.Add(new global::System.Collections.Generic.KeyValuePair<string, string>("client_secret", clientSecret));
            }
            if (!string.IsNullOrWhiteSpace(codeVerifier))
            {
                body.Add(new global::System.Collections.Generic.KeyValuePair<string, string>("code_verifier", codeVerifier));
            }

            return await ExchangeOAuth2TokenAsync(
                tokenUrl: new global::System.Uri("/v1/oauth/token"),
                body: body,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Refreshes the current OAuth2 token using the refresh token flow.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>The refreshed OAuth2 token.</returns>

        public async global::System.Threading.Tasks.Task<OAuth2Token> RefreshOAuth2TokenAsync(
            string clientId,
            string? clientSecret = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            clientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));

            var currentToken = GetOAuth2Token() ??
                throw new global::System.InvalidOperationException("OAuth2 token was not available.");
            if (string.IsNullOrWhiteSpace(currentToken.RefreshToken))
            {
                throw new global::System.InvalidOperationException("refresh_token was not present in the stored OAuth2 token.");
            }

            var body = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
            {
                new global::System.Collections.Generic.KeyValuePair<string, string>("grant_type", "refresh_token"),
                new global::System.Collections.Generic.KeyValuePair<string, string>("client_id", clientId),
                new global::System.Collections.Generic.KeyValuePair<string, string>("refresh_token", currentToken.RefreshToken),
            };
            if (!string.IsNullOrWhiteSpace(clientSecret))
            {
                body.Add(new global::System.Collections.Generic.KeyValuePair<string, string>("client_secret", clientSecret));
            }

            var refreshedToken = await ExchangeOAuth2TokenAsync(
                tokenUrl: new global::System.Uri("/v1/oauth/token"),
                body: body,
                requestedScope: currentToken.Scope,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            refreshedToken.RefreshToken ??= currentToken.RefreshToken;
            refreshedToken.Scope ??= currentToken.Scope;
            AuthorizeUsingOAuth2(refreshedToken);

            return refreshedToken;
        }

        /// <inheritdoc/>

        public async global::System.Threading.Tasks.Task AuthorizeUsingOAuth2WithAuthorizationCodeAsync(
            string clientId,
            string code,
            string redirectUri,
            string? clientSecret = null,
            string? codeVerifier = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var token = await ExchangeOAuth2CodeForTokenAsync(
                clientId: clientId,
                code: code,
                redirectUri: redirectUri,
                clientSecret: clientSecret,
                codeVerifier: codeVerifier,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ConfigureOAuth2TokenRefresh(
                refreshTokenAsync: cancellationToken => RefreshOAuth2TokenAsync(
                    clientId: clientId,
                    clientSecret: clientSecret,
                    cancellationToken: cancellationToken));

            AuthorizeUsingOAuth2(token);
        }


        /// <summary>
        /// Creates a PKCE code verifier.
        /// </summary>
        /// <returns>The code verifier.</returns>
        public static string CreateOAuth2PkceCodeVerifier()
        {
            var bytes = new byte[32];
            using (var randomNumberGenerator = global::System.Security.Cryptography.RandomNumberGenerator.Create())
            {
                randomNumberGenerator.GetBytes(bytes);
            }

            return ToOAuth2Base64Url(bytes);
        }

        /// <summary>
        /// Creates a PKCE code challenge from a verifier.
        /// </summary>
        /// <param name="codeVerifier"></param>
        /// <returns>The code challenge.</returns>
        public static string CreateOAuth2PkceCodeChallenge(
            string codeVerifier)
        {
            codeVerifier = codeVerifier ?? throw new global::System.ArgumentNullException(nameof(codeVerifier));

            var bytes = global::System.Text.Encoding.ASCII.GetBytes(codeVerifier);
#if NET10_0_OR_GREATER
            var hash = global::System.Security.Cryptography.SHA256.HashData(bytes);
#else
            byte[] hash;
            using (var sha256 = global::System.Security.Cryptography.SHA256.Create())
            {
                hash = sha256.ComputeHash(bytes);
            }
#endif
            return ToOAuth2Base64Url(hash);
        }

        private static string ToOAuth2Base64Url(
            byte[] bytes)
        {
            bytes = bytes ?? throw new global::System.ArgumentNullException(nameof(bytes));

            return global::System.Convert.ToBase64String(bytes)
                .TrimEnd('=')
                .Replace('+', '-')
                .Replace('/', '_');
        }
        private static string ToOAuth2ScopeValue(
            OAuth2Scope scope)
        {
            return scope switch
            {
                OAuth2Scope.Read => "read",                OAuth2Scope.Write => "write",
                _ => throw new global::System.NotImplementedException("OAuth2 scope not implemented."),
            };
        }

        private static string? JoinOAuth2Scopes(
            global::System.Collections.Generic.IEnumerable<OAuth2Scope>? scopes)
        {
            if (scopes is null)
            {
                return null;
            }

            return string.Join(" ", global::System.Linq.Enumerable.Select(scopes, static x => ToOAuth2ScopeValue(x)));
        }
    }
}