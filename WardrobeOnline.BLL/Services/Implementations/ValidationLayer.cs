﻿using System.Net;

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
                errorResponse.Body = "ID sent by client is invalid";
                errorResponse.Code = (int)HttpStatusCode.BadRequest;
                return errorResponse;
            }

            bool passed = await _crudProvider.TryRemoveAsync(id);
            if (!passed)
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = $"Failed to delete {nameof(TEntityDTO)} {id}";
                errorResponse.Code = (int)HttpStatusCode.BadRequest;
                return errorResponse;
            }

            return null;
        }

        public async Task<(ErrorResponse?, TEntityDTO?)> Get(int id)
        {
            if (IsCorrectID(id))
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "ID sent by client is invalid";
                errorResponse.Code = (int)HttpStatusCode.BadRequest;
                return (errorResponse, null);
            }

            TEntityDTO? responseDTO = await _crudProvider.TryGetAsync(id);

            if (responseDTO == null)
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "Entity with such ID wasn't found";
                errorResponse.Code = (int)HttpStatusCode.BadRequest;
                return (errorResponse, null);
            }

            return (null, responseDTO);
        }

        public async Task<(ErrorResponse?, TEntityDTO?)> Post(TEntityDTO entityDTO)
        {
            if (entityDTO is null)
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "Body contains no info";
                errorResponse.Code = (int)HttpStatusCode.BadRequest;
                return (errorResponse, null);
            }

            TEntityDTO? responseDTO = await _crudProvider.TryAddAsync(entityDTO);
            bool passed = responseDTO is not null;

            if (!passed)
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "Failed to apply data";
                errorResponse.Code = (int)HttpStatusCode.BadRequest;
                return (errorResponse, null);
            }

            return (null, responseDTO);
        }

        public async Task<(ErrorResponse?, TEntityDTO?)> Put(int? id, TEntityDTO entityDTO)
        {
            bool hasID = id is not null || entityDTO.ID != default;

            if (!hasID)
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "Request contains no ID, unable to proceed";
                errorResponse.Code = (int)HttpStatusCode.BadRequest;
                return (errorResponse, null);
            }

            id = id is null ? entityDTO.ID : id; // выбираем ID; id в запросе приоритетен

            if (IsCorrectID(id.Value))
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "ID sent by client is invalid";
                errorResponse.Code = (int)HttpStatusCode.BadRequest;
                return (errorResponse, null);
            }

            entityDTO.ID = id.Value;

            TEntityDTO? responseDTO = await _crudProvider.TryUpdateAsync(entityDTO);
            bool passed = responseDTO is not null;

            if (!passed)
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "Failed to update data";
                errorResponse.Code = (int)HttpStatusCode.BadRequest;
                return (errorResponse, null);
            }

            return (null, responseDTO);
        }

        private bool IsCorrectID(int id) => id > 0;
    }
}
