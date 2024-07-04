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
        [HttpGet("UserPersons/{token}")]
        public IResult GetUserPersonsIDs(int token)
        {
            throw new NotImplementedException();
        }

        [HttpGet("/{id}")]
        public IResult GetPersonInfo(int id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("/{id}")]
        public IResult DeletePerson(int id) 
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(PersonDTO))]
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
            if(personDTO.ID != default)
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

        [HttpPost("Update/")]
        public IResult UpdatePersonInfo(int token, int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("Physique/{id}")]
        public IResult GetPersonPhysiques(int id, int token)
        {
            throw new NotImplementedException();
        }

        [HttpPost("physique/{token}")]
        public IResult CreatePhysique(int token)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("physique/{id}/{token}")]
        public IResult DeletePhysique(int id, int token)
        {
            throw new NotImplementedException();
        }
        [HttpPost("physique/update/{id}/{token}")]
        public IResult UpdatePhysique(int id, int token)
        {
            throw new NotImplementedException();
        }

       
    }
}
