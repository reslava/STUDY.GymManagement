using ErrorOr;
using MediatR;
using GymManagement.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Text;
using GymManagement.Application.Common.Interfaces;


namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription
{
    internal sealed class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, ErrorOr<Subscription>>
    {
        private readonly ISubscriptionsRepository _subscriptionsRepository;

        public CreateSubscriptionCommandHandler (ISubscriptionsRepository subscriptionsRepository)
        {
            _subscriptionsRepository = subscriptionsRepository;
        }

        public async Task<ErrorOr<Subscription>> Handle (CreateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            // Create a Subscription
            var subscription = new Subscription
            {
                Id = Guid.NewGuid ()
            };
            // Add to the repository (Db)
            _subscriptionsRepository.AddSubscription (subscription);
            return subscription;
        }        
    }
}
