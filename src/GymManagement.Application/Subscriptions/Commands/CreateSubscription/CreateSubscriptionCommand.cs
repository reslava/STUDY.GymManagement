using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription
{
    public record CreateSubscriptionCommand(Guid adminId, string subscriptionType) : IRequest<ErrorOr<Guid>>;    
}
