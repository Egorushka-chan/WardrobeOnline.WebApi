﻿using Microsoft.AspNetCore.Mvc;

using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Services.Interfaces;

namespace WardrobeOnline.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PersonDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [HttpGet("{id}")]
        public async Task<IResult> GetPersonInfo(int id, [FromServices] IValidationLayer<PersonDTO> validationLayer, [FromServices] ILogger<PersonController> logger)
        {
            logger.LogInformation("Get Person Request at {0}", DateTime.Now);
            (ErrorResponse? errorResponse, PersonDTO? dto) = await validationLayer.Get(id);

            if(errorResponse != null)
                return TypedResults.BadRequest(errorResponse);
            else
                return TypedResults.Ok(dto);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [HttpDelete("{id}")]
        public async Task<IResult> DeletePerson(int id, [FromServices] IValidationLayer<PersonDTO> validationLayer) 
        {
            ErrorResponse? errorResponse = await validationLayer.Delete(id);
            if (errorResponse != null)
                return TypedResults.BadRequest(errorResponse);

            return TypedResults.NoContent();
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PersonDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [HttpPost]
        public async Task<IResult> CreatePerson([FromBody] PersonDTO personDTO, [FromServices] IValidationLayer<PersonDTO> validationLayer) 
        {
            (ErrorResponse? errorResponse, PersonDTO? dto) = await validationLayer.Post(personDTO);

            if (errorResponse != null)
                return TypedResults.BadRequest(errorResponse);
            else
                return TypedResults.Ok(dto);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PersonDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [HttpPut("{id?}")]
        public async Task<IResult> UpdatePersonInfo(int? id, [FromBody] PersonDTO personDTO, [FromServices] IValidationLayer<PersonDTO> validationLayer)
        {
            (ErrorResponse? errorResponse, PersonDTO? dto) = await validationLayer.Put(id,personDTO);

            if (errorResponse != null)
                return TypedResults.BadRequest(errorResponse);
            else
                return TypedResults.Ok(dto);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<PersonDTO>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [HttpGet("page/{pageIndex}/{pageSize}")]
        public async Task<IResult> GetPage(int pageIndex, int pageSize, [FromServices] IValidationLayer<PersonDTO> validationLayer)
        {
            (ErrorResponse? errorResponse, IReadOnlyList<PersonDTO>? list) = await validationLayer.GetPaged(pageIndex, pageSize);

            if (errorResponse != null)
                return TypedResults.BadRequest(errorResponse);
            else
                return TypedResults.Ok(list);
        }
    }
}
