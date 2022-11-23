using Microsoft.AspNetCore.Mvc;
using RestWebApi.BLL.Abstractions;
using RestWebApi.DAL;

namespace RestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RowController : ControllerBase
    {
        private readonly IEntityManager<Row> _entityManager;

        public RowController(IEntityManager<Row> entityManager)
        {
            _entityManager = entityManager;
        }

        [HttpGet]
        public IEnumerable<Row> GetAll() => _entityManager.GetAll();

        [HttpGet("{id}")]
        public async Task<Row?> GetById(Guid id) => await _entityManager.GetByIdAsync(id);

        [HttpPost]
        public async Task<Row> Create(Row model) => await _entityManager.CreateAsync(model);

        [HttpPut]
        public async Task<Row> Update(Row model) => await _entityManager.UpdateAsync(model);

        [HttpDelete]
        public async Task<Row> Delete(Row model) => await _entityManager.DeleteAsync(model);
    }
}