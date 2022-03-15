﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Pass is required")
            .MinimumLength(6).WithMessage("Password is at least 6 characters");
        }

    }
}
