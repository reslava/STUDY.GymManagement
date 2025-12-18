using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Services
{
    internal sealed class SubscriptionsService : ISubscriptionsService
    {
        public Guid CreateSubscription (Guid subscriptionId, string subscriptionType)
        {
            return Guid.NewGuid();
        }
    }
}
