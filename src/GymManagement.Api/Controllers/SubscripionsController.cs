using GymManagement.Application.Services;
using GymManagement.Contracts.Subscriptions;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;


namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionsController : ControllerBase
{
    private ISubscriptionsService _subscriptionsService;

    public SubscriptionsController (ISubscriptionsService subscriptionsService)
    {
        _subscriptionsService = subscriptionsService;
    }

    [HttpPost]
    public IActionResult CreateSubscription(CreateSubscriptionRequest request)
    {
        var subscriptionId = _subscriptionsService.CreateSubscription (
            request.AdminId, 
            request.SubscriptionType.ToString ());
        var response = new SubscriptionResponse (subscriptionId, request.SubscriptionType);
        return Ok(response);

    }

}