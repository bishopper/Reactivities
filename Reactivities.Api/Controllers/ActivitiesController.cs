using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Services.Interfaces;

namespace Reactivities.Api.Controllers;
public class ActivitiesController : BaseApiController
{
    private readonly IActivitiesService _activitiesService;
    public ActivitiesController(IActivitiesService activitiesService)
    {
        _activitiesService = activitiesService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllActivities()
    {
        var activities = await _activitiesService.GetAllActivitiesAsync();
        return new JsonResult(activities);
    }
}
