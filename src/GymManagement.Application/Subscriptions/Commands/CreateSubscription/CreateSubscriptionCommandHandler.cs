using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription
{
    internal sealed class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, Guid>
    {
        public Task<Guid> Handle (CreateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Guid.NewGuid());
        }
    }
}
