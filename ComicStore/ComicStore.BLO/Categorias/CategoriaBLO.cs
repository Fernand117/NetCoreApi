using ComicStore.COMMON.DTOS;
using ComicStore.COMMON.DTOS.Categorias;
using ComicStore.COMMON.RESOURCES;
using ComicStore.DAO.Categorias;
using System;
using System.Threading.Tasks;

namespace ComicStore.BLO.Categorias
{
    public class CategoriaBLO
    {
        public async Task<ApiResponse> Create(CategoriasRequest request)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                apiResponse.ResponseCode = Response.Success;
                apiResponse.ResponseText = ComicResources.MensajeOk;
                apiResponse.Data = await new CategoriaDAO().Create(request);
            }
            catch (Exception)
            {
                apiResponse.ResponseCode = Response.Error;
                apiResponse.ResponseText = ComicResources.MensajeError;
                apiResponse.Data = null;
            }

            return apiResponse;
        }

        public async Task<ApiResponse> Read()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                apiResponse.ResponseCode = Response.Success;
                apiResponse.ResponseText = ComicResources.MensajeOk;
                apiResponse.Data = await new CategoriaDAO().Read();
            }
            catch (Exception)
            {
                apiResponse.ResponseCode = Response.Error;
                apiResponse.ResponseText = ComicResources.MensajeError;
                apiResponse.Data = null;
            }

            return apiResponse;
        }

        public async Task<ApiResponse> Read(int IdCategoria)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                apiResponse.ResponseCode = Response.Success;
                apiResponse.ResponseText = ComicResources.MensajeOk;
                apiResponse.Data = await new CategoriaDAO().Read(IdCategoria);
            }
            catch (Exception)
            {
                apiResponse.ResponseCode = Response.Error;
                apiResponse.ResponseText = ComicResources.MensajeError;
                apiResponse.Data = null;
            }

            return apiResponse;
        }

        public async Task<ApiResponse> Update(CategoriasRequest request)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                apiResponse.ResponseCode = Response.Success;
                apiResponse.ResponseText = ComicResources.MensajeOk;
                apiResponse.Data = await new CategoriaDAO().Update(request);
            }
            catch (Exception)
            {
                apiResponse.ResponseCode = Response.Error;
                apiResponse.ResponseText = ComicResources.MensajeError;
                apiResponse.Data = null;
            }

            return apiResponse;
        }

        public async Task<ApiResponse> Delete(CategoriasRequest request)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                apiResponse.ResponseCode = Response.Success;
                apiResponse.ResponseText = ComicResources.MensajeOk;
                apiResponse.Data = await new CategoriaDAO().Delete(request);
            }
            catch (Exception)
            {
                apiResponse.ResponseCode = Response.Error;
                apiResponse.ResponseText = ComicResources.MensajeError;
                apiResponse.Data = null;
            }

            return apiResponse;
        }
    }
}
