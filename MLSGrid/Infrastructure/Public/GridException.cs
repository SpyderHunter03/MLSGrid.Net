using System.Net;

namespace MLSGrid
{
    public class GridException : Exception
    {
        public GridException()
        {
        }

        public GridException(string message)
            : base(message)
        {
        }

        public GridException(string message, Exception err)
            : base(message, err)
        {
        }

        public GridException(HttpStatusCode httpStatusCode, GridError gridError, string message)
            : base(message)
        {
            this.HttpStatusCode = httpStatusCode;
            this.GridError = gridError;
        }

        public HttpStatusCode HttpStatusCode { get; set; }

        public GridError GridError { get; set; }

        public GridResponse GridResponse { get; set; }
    }
}
