﻿using productClientHub.Exceptions.ExceptionsBase;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;

namespace productClientHub.API.UseCases.Clients.Register
{
    public class RegisterClientUseCase
    {
        public ResponseClientJson Execute(RequestClientJson request)
        {
            var validator = new RegisterClientValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();

                throw new ErrorOnValidationException(errors);
            }

            return new ResponseClientJson();
        }
    }
}
