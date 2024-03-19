using FluentValidation;

namespace Celestio.Core.Models.User;

public class LoginDto
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

public class LoginValidator : AbstractValidator<LoginDto>
{
    public LoginValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("It is not valid email address");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required.")
            .Length(1, 100).WithMessage("Password must be at least 8 characters long.");
    }
}