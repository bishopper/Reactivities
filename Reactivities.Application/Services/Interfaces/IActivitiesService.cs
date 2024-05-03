using Reactivities.Domain.Entities.User;

namespace Reactivities.Application.Services.Interfaces;
public interface IActivitiesService
{
    Task<List<Activity>> GetAllActivitiesAsync();
}
