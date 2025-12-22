using GymManagement.Application.Services;
using GymManagement.Application.Subscriptions.Commands.CreateSubscription;
using GymManagement.Contracts.Subscriptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;


namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionsController : ControllerBase
{
    //private readonly ISubscriptionsService _subscriptionsService;
    private readonly ISender _mediator;

    public SubscriptionsController (ISender mediator)
    {        
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateSubscription(CreateSubscriptionRequest request)
    {
        var command = new CreateSubscriptionCommand(
            request.AdminId,
            request.SubscriptionType.ToString ());

        var createSubscriptionResult = await _mediator.Send (command);

        return createSubscriptionResult.MatchFirst (
            subscription => Ok(new SubscriptionResponse(subscription.Id, request.SubscriptionType)),
            ErrorEventArgs => Problem());

        /* Now implemented by 'ErrorOr.MatchFirst'
         * if(createSubscriptionResult.IsError)
        {
            return Problem ();
        }
            
        var response = new SubscriptionResponse (
            createSubscriptionResult.Value, 
            request.SubscriptionType);
        return Ok(response);*/        
    }

}