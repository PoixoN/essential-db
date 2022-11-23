using Microsoft.AspNetCore.Mvc;
using RestWebApi.BLL.Abstractions;
using RestWebApi.DAL;

namespace RestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DatabaseController : ControllerBase
    {
        private readonly IEntityManager<Database> _entityManager;

        public DatabaseController(IEntityManager<Database> entityManager)
        {
            _entityManager = entityManager;
        }

        [HttpGet]
        public IEnumerable<Database> GetAll() => _entityManager.GetAll();

        [HttpGet("{id}")]
        public async Task<Database?> GetById(Guid id) => await _entityManager.GetByIdAsync(id);

        [HttpPost]
        public async Task<Database> Create(Database model) => await _entityManager.CreateAsync(model);

        [HttpPut]
        public async Task<Database> Update(Database model) => await _entityManager.UpdateAsync(model);

        [HttpDelete]
        public async Task<Database> Delete(Database model) => await _entityManager.DeleteAsync(model);
    }
}