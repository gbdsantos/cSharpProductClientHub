using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;

namespace productClientHub.API.UseCases.Clients.Register
{
    public class RegisterClientUseCase
    {
        public ResponseClientJson Execute(RequestClientJson request)
        {
            var validator = new RegisterClientValidator();

            return new ResponseClientJson();
        }
    }
}
