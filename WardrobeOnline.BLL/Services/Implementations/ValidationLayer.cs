using System.Net;

using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.BLL.Services.Interfaces;
using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.BLL.Services.Implementations
{
    public class ValidationLayer<TEntityDTO>(ICRUDProvider<TEntityDTO> _crudProvider) : IValidationLayer<TEntityDTO> where TEntityDTO : class, IEntityDTO
    {
        public async Task<ErrorResponse?> Delete(int id)
        {
            if(IsCorrectID(id))
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "Invalid ID";
                errorResponse.Code = (int)HttpStatusCode.BadRequest;
                return errorResponse;
            }

            bool passed = await _crudProvider.TryRemove(id);
            if (!passed)
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = $"Failed to delete Person {id}";
                errorResponse.Code = (int)HttpStatusCode.BadRequest;
                return errorResponse;
            }

            return null;
        }

        public async Task<(ErrorResponse?, TEntityDTO)> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<(ErrorResponse?, TEntityDTO)> Post(TEntityDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<(ErrorResponse?, TEntityDTO)> Put(TEntityDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        private bool IsCorrectID(int id) => id > 0;
    }
}
