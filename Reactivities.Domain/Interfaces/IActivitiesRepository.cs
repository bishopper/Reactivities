using Reactivities.Domain.Entities.User;

namespace Reactivities.Domain.Interfaces;
public interface IActivitiesRepository
{
    Task<List<Activity>> GetAllActivitiesAsync();
}
