using Microsoft.EntityFrameworkCore;
using Reactivities.Domain.Entities.User;
using Reactivities.Domain.Interfaces;
using Reactivities.Infra.Data.Context;

namespace Reactivities.Infra.Data.Repositories;
public class ActivitiesRepository : IActivitiesRepository
{
    public readonly ReactivitiesDBContext _dbContext;

    public ActivitiesRepository(ReactivitiesDBContext reactivitiesDBContext)
    {
        _dbContext = reactivitiesDBContext;
    }


    public async Task<List<Activity>> GetAllActivitiesAsync()
    {
        return await _dbContext.Activities.ToListAsync();
    }
}
