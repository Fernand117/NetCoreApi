using ComicStore.COMMON.DTOS.Categorias;
using ComicStore.DAL.Context;
using ComicStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicStore.DAO.Categorias
{
    public class CategoriaDAO
    {
        public async Task<CategoriasRequest> Create(CategoriasRequest request)
        {
            try
            {
                using(ComicContext context = new ComicContext())
                {
                    Categoria categoria = new Categoria()
                    {
                        Nombre = request.Nombre,
                        Estado = "ACTIVO"
                    };

                    await context.AddAsync(categoria);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex) { }
            
            return request;
        }

        public async Task<List<CategoriaDTO>> Read()
        {
            List<CategoriaDTO> response = new List<CategoriaDTO>();

            try
            {
                using (ComicContext context = new ComicContext())
                {
                    //select * from categorias
                    //var categorias = await context.Categorias.ToListAsync();

                    var categorias = await context.Categorias
                                                  .Where(c => c.Estado == "ACTIVO")
                                                  .ToListAsync();

                    foreach (var c in categorias)
                    {
                        response.Add(new CategoriaDTO()
                        {
                            IdCategoria = c.Id,
                            Categoria = c.Nombre
                        });
                    }
                }
            }
            catch (Exception) { }
            return response;
        }

        public async Task<CategoriaDTO> Read(int IdCategoria)
        {
            CategoriaDTO response = new CategoriaDTO();

            try
            {
                using(ComicContext context = new ComicContext())
                {
                    var categoria = await context.Categorias
                                                 .Where(c => c.Id == IdCategoria)
                                                 .FirstOrDefaultAsync();
                    if (categoria != null)
                    {
                        response.IdCategoria = categoria.Id;
                        response.Categoria = categoria.Nombre;
                    }
                }
            }
            catch (Exception e) { }

            return response;
        }

        public async Task<CategoriasRequest> Update(CategoriasRequest request)
        {
            try
            {
                using(ComicContext context = new ComicContext())
                {
                    var categoria = await context.Categorias
                                                 .Where(c => c.Id == request.IdCategoria)
                                                 .FirstOrDefaultAsync();
                    if (categoria != null)
                    {
                        categoria.Nombre = request.Nombre;
                        await context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex) { }
            
            return request;
        }

        public async Task<CategoriasRequest> Delete(int id)
        {
            try
            {
                using (ComicContext context = new ComicContext())
                {
                    var categoria = await context.Categorias
                                                 .Where(c => c.Id == id)
                                                 .FirstOrDefaultAsync();
                    if (categoria != null)
                    {
                        categoria.Estado = "INACTIVO";
                        await context.SaveChangesAsync();

                        /*
                         * ELIMINACIÓN FÍSICA
                         * context.Entry(categoria).State = EntityState.Deleted;
                         */
                    }
                }
            }
            catch (Exception ex) { }

            return new CategoriasRequest()
            {
                IdCategoria = id
            };
        }
    }
}
