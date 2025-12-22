using GymManagement.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Common.Interfaces;

public interface ISubscriptionsRepository
{
    void AddSubscription(Subscription subscription);
}
