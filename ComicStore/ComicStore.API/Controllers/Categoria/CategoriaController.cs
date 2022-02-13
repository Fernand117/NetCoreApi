using ComicStore.BLO.Categorias;
using ComicStore.COMMON.DTOS;
using ComicStore.COMMON.DTOS.Categorias;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ComicStore.API.Controllers.Categoria
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<ApiResponse>> Get() => await new CategoriaBLO().Read();

        [HttpGet("{idCategoria}")]
        public async Task<ActionResult<ApiResponse>> Get(int IdCategoria) => await new CategoriaBLO().Read(IdCategoria);

        [HttpPost]
        public async Task<ActionResult<ApiResponse>> Post([FromBody] CategoriasRequest request) => await new CategoriaBLO().Create(request);

        [HttpPut]
        public async Task<ActionResult<ApiResponse>> Put([FromBody] CategoriasRequest request) => await new CategoriaBLO().Update(request);

        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> Delete(int id) => await new CategoriaBLO().Delete(id);
    }
}
