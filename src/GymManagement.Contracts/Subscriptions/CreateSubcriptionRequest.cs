using System.Runtime.InteropServices;

namespace GymManagement.Contracts.Subscriptions;

public record CreateSubscriptionRequest(SubscriptionType SubscriptionType, Guid AdminId)