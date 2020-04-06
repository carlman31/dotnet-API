using System.Data.Entity;

public interface IDbContext
{
    IDbSet<TEntity> Set<TEntity>() where TEntity : CarlosCuellarApi.Models.Student;
    int SaveChanges();
}