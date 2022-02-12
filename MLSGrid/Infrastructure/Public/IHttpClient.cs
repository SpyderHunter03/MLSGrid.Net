namespace MLSGrid
{
    /// <summary>
    /// Interface for HTTP clients used to make requests to Stripe's API.
    /// </summary>
    public interface IHttpClient
    {
        /// <summary>Sends a request to Stripe's API as an asynchronous operation.</summary>
        /// <param name="request">The parameters of the request to send.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GridResponse> MakeRequestAsync(
            GridRequest request,
            CancellationToken cancellationToken = default);

        Task<GridStreamedResponse> MakeStreamingRequestAsync(
            GridRequest request,
            CancellationToken cancellationToken = default);
    }
}
