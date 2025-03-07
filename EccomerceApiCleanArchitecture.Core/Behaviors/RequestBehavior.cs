using EccomerceApiCleanArchitecture.Core.Bases;
using FluentValidation;
using MediatR;
using System.Net;

namespace EccomerceApiCleanArchitecture.Core.Behaviors
{
    public class RequestBehavior<TRequest, TResponse> :
        ResponseHandler,
        IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public RequestBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (_validators.Any())
            {
                var context = new ValidationContext<TRequest>(request);
                var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));
                var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();

                if (failures.Count != 0)
                {
                 
                    throw new ValidationException(failures);
                }
            }

            return await next();
        }
    }
}
