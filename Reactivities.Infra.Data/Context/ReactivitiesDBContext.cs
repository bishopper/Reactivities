using Microsoft.EntityFrameworkCore;
using Reactivities.Domain.Entities.User;

namespace Reactivities.Infra.Data.Context;
public class ReactivitiesDBContext : DbContext
{
    #region Constructor

    public ReactivitiesDBContext(DbContextOptions<ReactivitiesDBContext> options) : base(options)
    {

    }

    #endregion


    #region User

    public DbSet<Activity> Activities { get; set; }

    #endregion
}
