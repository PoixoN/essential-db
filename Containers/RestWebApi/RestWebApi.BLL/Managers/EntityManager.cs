using Infrastructure.Package.ResponseResult;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RestWebApi.BLL.Abstractions;
using RestWebApi.DAL;
using System.Collections;

namespace RestWebApi.BLL.Managers
{
    public class EntityManager<Entity> : IEntityManager<Entity> where Entity : BaseEntity, new()
    {
        public RestWebApiDbContext _dbContext { get; set; }

        public EntityManager(RestWebApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<Entity> GetAll() => _dbContext.Set<Entity>().AsNoTracking().ToList();

        public async Task<Entity?> GetByIdAsync(Guid Id) => await _dbContext.Set<Entity>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == Id);
        
        public async Task<Entity> CreateAsync(Entity model)
        {
                _dbContext.Set<Entity>().Add(model);
                await _dbContext.SaveChangesAsync();
                return model;
        }

        public async Task<Entity> UpdateAsync(Entity model)
        {
            _dbContext.Set<Entity>().Update(model);
            await _dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<Entity> DeleteAsync(Entity model)
        {
            _dbContext.Set<Entity>().Remove(model);
            await _dbContext.SaveChangesAsync();
            return model;
        }
    }
}

