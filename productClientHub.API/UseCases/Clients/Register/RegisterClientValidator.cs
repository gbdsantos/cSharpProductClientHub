﻿using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace productClientHub.API.UseCases.Clients.Register
{
    public class RegisterClientValidator: AbstractValidator<RequestClientJson>
    {
        public RegisterClientValidator()
        {
            RuleFor(client => client.Name).NotEmpty().WithMessage("O nome não pode ser vazio.");
            RuleFor(client => client.Email).EmailAddress().WithMessage("O e-mail não é válido.");

        }
    }
}
