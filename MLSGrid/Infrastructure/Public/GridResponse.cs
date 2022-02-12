using System.Net;
using System.Net.Http.Headers;

namespace MLSGrid
{
    /// <summary>
    /// Represents a buffered textual response from Stripe's API.
    /// </summary>
    public class GridResponse : GridResponseBase
    {
        /// <summary>Initializes a new instance of the <see cref="StripeResponse"/> class.</summary>
        /// <param name="statusCode">The HTTP status code.</param>
        /// <param name="headers">The HTTP headers of the response.</param>
        /// <param name="content">The body of the response.</param>
        public GridResponse(HttpStatusCode statusCode, HttpResponseHeaders headers, string content)
            : base(statusCode, headers)
        {
            this.Content = content;
        }

        /// <summary>Gets the body of the response.</summary>
        /// <value>The body of the response.</value>
        public string Content { get; }
    }
}
