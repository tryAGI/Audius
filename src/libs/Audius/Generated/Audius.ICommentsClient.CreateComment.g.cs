#nullable enable

namespace Audius
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Creates a new comment
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CreateCommentResponse> CreateCommentAsync(
            string userId,

            global::Audius.CreateCommentRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new comment
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.CreateCommentResponse>> CreateCommentAsResponseAsync(
            string userId,

            global::Audius.CreateCommentRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new comment
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="entityType">
        /// Example: Track
        /// </param>
        /// <param name="entityId">
        /// ID of the entity being commented on<br/>
        /// Example: 12345
        /// </param>
        /// <param name="body">
        /// Comment text<br/>
        /// Example: Great track!
        /// </param>
        /// <param name="commentId">
        /// Optional ID for the comment (will be generated if not provided)<br/>
        /// Example: 98765
        /// </param>
        /// <param name="parentId">
        /// Parent comment ID if this is a reply<br/>
        /// Example: 54321
        /// </param>
        /// <param name="trackTimestampS">
        /// Timestamp in the track where the comment was made (in seconds)
        /// </param>
        /// <param name="mentions">
        /// Array of user IDs mentioned in the comment (max 10)
        /// </param>
        /// <param name="videoUrl">
        /// Optional URL for a video attachment (stored on the comment record)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CreateCommentResponse> CreateCommentAsync(
            string userId,
            global::Audius.CommentEntityType entityType,
            int entityId,
            string body,
            int? commentId = default,
            int? parentId = default,
            int? trackTimestampS = default,
            global::System.Collections.Generic.IList<int>? mentions = default,
            string? videoUrl = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}