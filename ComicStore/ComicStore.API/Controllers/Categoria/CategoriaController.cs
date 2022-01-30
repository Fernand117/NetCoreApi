﻿using ComicStore.BLO.Categorias;
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
        /* TAREA
         * Cómo crear un enviroment
         * Desde Postman enviar peticiones al API
         * Generar migraciones
         * Poner la relación 1:M en el API Fuence
         */

        [HttpGet]
        public async Task<ActionResult<ApiResponse>> Get() => await new CategoriaBLO().Read();

        [HttpGet("/{idCategoria}")]
        public async Task<ActionResult<ApiResponse>> Get(int IdCategoria) => await new CategoriaBLO().Read(IdCategoria);

        [HttpPost]
        public async Task<ActionResult<ApiResponse>> Post([FromBody] CategoriasRequest request) => await new CategoriaBLO().Create(request);

        [HttpPut]
        public async Task<ActionResult<ApiResponse>> Put([FromBody] CategoriasRequest request) => await new CategoriaBLO().Update(request);

        [HttpDelete]
        public async Task<ActionResult<ApiResponse>> Delete([FromBody] CategoriasRequest request) => await new CategoriaBLO().Delete(request);
    }
}
