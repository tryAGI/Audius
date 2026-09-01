#nullable enable

namespace Audius
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Unreact to a comment
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.WriteResponse> UnreactToCommentAsync(
            string commentId,
            string userId,

            global::Audius.ReactCommentRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unreact to a comment
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.WriteResponse>> UnreactToCommentAsResponseAsync(
            string commentId,
            string userId,

            global::Audius.ReactCommentRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unreact to a comment
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="userId"></param>
        /// <param name="entityType">
        /// Example: Track
        /// </param>
        /// <param name="entityId">
        /// ID of the entity (track) being commented on<br/>
        /// Example: 12345
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.WriteResponse> UnreactToCommentAsync(
            string commentId,
            string userId,
            global::Audius.CommentEntityType entityType,
            int entityId,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}