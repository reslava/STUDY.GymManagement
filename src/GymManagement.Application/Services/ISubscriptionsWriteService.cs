using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Services
{
    public interface ISubscriptionsWriteService
    {
        Guid CreateSubscription(Guid subscriptionId, string subscriptionType);
    }
}
