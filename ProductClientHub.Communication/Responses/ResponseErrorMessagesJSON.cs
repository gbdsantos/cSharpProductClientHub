namespace ProductClientHub.Communication.Responses
{
    public class ResponseErrorMessagesJSON
    {
        public List<string> Errors { get; private set; }

        public ResponseErrorMessagesJSON(string message)
        {
            Errors = [message];
        }
    }
}
