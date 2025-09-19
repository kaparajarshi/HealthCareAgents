using FluentValidation;
using HealthCareAgenticAI.Helpers;
using HealthCareAgenticAI.Models;

namespace HealthCareAgenticAI.Validators
{
    public class RequestValidator : AbstractValidator<RequestModel>
    {
        public RequestValidator()
        {
            _ = RuleFor(x => x.ClaimId)
                .NotEmpty().WithMessage("ClaimId is required.")
                .Matches(CustomRegex.ClaimIdStrict())
                .WithMessage("ClaimId must be alphanumeric with optional dashes.");
        }
    }
}