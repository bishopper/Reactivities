using Reactivities.Application.Services.Interfaces;
using Reactivities.Domain.Entities.User;
using Reactivities.Domain.Interfaces;

namespace Reactivities.Application.Services.Implementation;
public class ActivitiesService : IActivitiesService
{
    private readonly IActivitiesRepository _activitiesRepository;
    public ActivitiesService(IActivitiesRepository activitiesRepository)
    {
        _activitiesRepository = activitiesRepository;
    }

    public async Task<List<Activity>> GetAllActivitiesAsync()
    {
        return await _activitiesRepository.GetAllActivitiesAsync();
    }
}
