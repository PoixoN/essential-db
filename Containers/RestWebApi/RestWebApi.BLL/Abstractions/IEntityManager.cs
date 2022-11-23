using Microsoft.EntityFrameworkCore;
using RestWebApi.DAL;

namespace RestWebApi.BLL.Abstractions
{
    public interface IEntityManager<Entity> where Entity : BaseEntity, new()
    {
        IList<Entity> GetAll();

        Task<Entity?> GetByIdAsync(Guid Id);

        Task<Entity> CreateAsync(Entity model);

        Task<Entity> UpdateAsync(Entity model);

        Task<Entity> DeleteAsync(Entity model);
    }
}
