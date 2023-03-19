using FastEndpoints.Swagger.ValidationSchemaInfiniteLoop.Example.Requests;
using FluentValidation;

namespace FastEndpoints.Swagger.ValidationSchemaInfiniteLoop.Example.Validations;

public class AddNodeRequestValidator : Validator<AddNodeRequest>
{
    public AddNodeRequestValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty();

        // Cause of the error
        RuleForEach(p => p.Nodes)
            .NotNull()
            .SetValidator(_ => new AddNodeRequestValidator());
    }
}