namespace Kreta.Shared.Responses
{
    public class Response : ErrorStore
    {
        public bool IsSuccess => !HasError;
        public Guid Id { get; set; }
        public Response() : base() { }
        public Response(string errorString) : base()
        {
            Error = errorString;
        }
    }
}
