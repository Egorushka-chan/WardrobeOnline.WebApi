using System.Xml.Linq;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Services.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PersonDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [HttpGet("/{id}")]
        public IResult GetPersonInfo(int id, [FromServices] ICRUDProvider<PersonDTO> crudProvider)
        {
            if(id < 1)
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "Invalid ID";
                return TypedResults.BadRequest(errorResponse);
            }

            PersonDTO? get = crudProvider.TryGet(id);
            if(get == null) 
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "Person with such ID wasn't found";
                return TypedResults.BadRequest(errorResponse);
            }

            return TypedResults.Ok(get);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [HttpDelete("/{id}")]
        public async Task<IResult> DeletePerson(int id, [FromServices] ICRUDProvider<PersonDTO> crudProvider) 
        {
            if(id < 1)
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "Invalid ID";
                return TypedResults.BadRequest(errorResponse);
            }

            bool passed = await crudProvider.TryRemove(id);
            if (!passed)
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = $"Failed to delete Person {id}";
                return TypedResults.BadRequest(errorResponse);
            }

            return TypedResults.NoContent();
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PersonDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [HttpPost("/")]
        public async Task<IResult> CreatePerson([FromBody] PersonDTO personDTO, [FromServices] ICRUDProvider<PersonDTO> crudProvider) 
        {
            if (personDTO is null)
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "Body contains no info";
                return TypedResults.BadRequest(errorResponse);
            }

            bool passed = await crudProvider.TryAdd(personDTO);
            PersonDTO? responseDTO = personDTO;

            if (personDTO.ID != default)
            {
                responseDTO = crudProvider.TryGet(personDTO.ID);
                passed = passed && responseDTO is not null;
            }

            if (!passed)
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "Failed to apply data";
                return TypedResults.BadRequest(errorResponse);
            }

            return TypedResults.Ok(responseDTO);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PersonDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [HttpPut("/{id?}")]
        public async Task<IResult> UpdatePersonInfo(int? id, [FromBody] PersonDTO personDTO, [FromServices] ICRUDProvider<PersonDTO> crudProvider)
        {
            // TODO: TryUpdate работает неправильно (создаёт вместо изменения)
            bool hasID = id is not null || personDTO.ID != default;

            if (!hasID) 
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "Request contains no ID, unable to proceed";
                return TypedResults.BadRequest(errorResponse);
            }

            id = id is null ? personDTO.ID : id; // выбираем ID; id в запросе приоритетен

            
            bool passed = await crudProvider.TryUpdate(personDTO);

            PersonDTO? responseDTO = personDTO;
            responseDTO = crudProvider.TryGet(personDTO.ID);
            passed = passed && responseDTO is not null;

            if (!passed) 
            {
                ErrorResponse errorResponse = new ErrorResponse();
                errorResponse.Body = "Failed to update data";
                return TypedResults.BadRequest(errorResponse);
            }

            return TypedResults.Ok(responseDTO);
        }

        [HttpGet("Physique/{id}")]
        public IResult GetPersonPhysiques(int id, int token)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Physique/")]
        public IResult CreatePhysique()
        {
            throw new NotImplementedException();
        }

        [HttpDelete("Physique/{id}")]
        public IResult DeletePhysique(int id, int token)
        {
            throw new NotImplementedException();
        }
        [HttpPut("Physique/{id}")]
        public IResult UpdatePhysique(int id, int token)
        {
            throw new NotImplementedException();
        }

       
    }
}
