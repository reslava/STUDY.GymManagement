using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription
{
    internal sealed class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, ErrorOr<Guid>>
    {
        public async Task<ErrorOr<Guid>> Handle (CreateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            return Error.
            return await Task.FromResult(Guid.NewGuid());
        }
    }
}
