using FluentValidation;
using Skeleton.Api.Resources;

namespace Skeleton.Api.Validators
{
    public class SaveArtistResourceValidator: AbstractValidator<SaveArtistResource>
    {
        public SaveArtistResourceValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}