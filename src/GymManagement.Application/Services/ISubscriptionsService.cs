using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Services
{
    public interface ISubscriptionsService
    {
        Guid CreateSubscription(Guid subscriptionId, string subscriptionType);
    }
}
