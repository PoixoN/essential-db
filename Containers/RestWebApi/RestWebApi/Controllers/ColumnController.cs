using Microsoft.AspNetCore.Mvc;
using RestWebApi.BLL.Abstractions;
using RestWebApi.DAL;
using RestWebApi.DAL.Entities.Columns.Abstractions;

namespace RestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColumnController : ControllerBase
    {
        private readonly IEntityManager<Column> _entityManager;

        public ColumnController(IEntityManager<Column> entityManager)
        {
            _entityManager = entityManager;
        }

        [HttpGet]
        public IEnumerable<Column> GetAll() => _entityManager.GetAll();

        [HttpGet("{id}")]
        public async Task<Column?> GetById(Guid id) => await _entityManager.GetByIdAsync(id);

        [HttpPost]
        public async Task<Column> Create(Column model) => await _entityManager.CreateAsync(model);

        [HttpPut]
        public async Task<Column> Update(Column model) => await _entityManager.UpdateAsync(model);

        [HttpDelete]
        public async Task<Column> Delete(Column model) => await _entityManager.DeleteAsync(model);
    }
}