using Microsoft.AspNetCore.Mvc;

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
        public async Task<IResult> GetPersonInfo(int id, [FromServices] IValidationLayer<PersonDTO> validationLayer)
        {
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

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PhysiqueDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [HttpGet("Physique/{id}")]
        public async Task<IResult> GetPersonPhysique(int id, [FromServices] IValidationLayer<PhysiqueDTO> validationLayer)
        {
            (ErrorResponse? errorResponse, PhysiqueDTO? dto) = await validationLayer.Get(id);

            if (errorResponse != null)
                return TypedResults.BadRequest(errorResponse);
            else
                return TypedResults.Ok(dto);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PhysiqueDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [HttpPost("Physique/")]
        public async Task<IResult> CreatePhysique([FromBody] PhysiqueDTO physiqueDTO, [FromServices] IValidationLayer<PhysiqueDTO> validationLayer)
        {
            (ErrorResponse? errorResponse, PhysiqueDTO? dto) = await validationLayer.Post(physiqueDTO);

            if (errorResponse != null)
                return TypedResults.BadRequest(errorResponse);
            else
                return TypedResults.Ok(dto);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [HttpDelete("Physique/{id}")]
        public async Task<IResult> DeletePhysique(int id, [FromServices] IValidationLayer<PhysiqueDTO> validationLayer)
        {
            ErrorResponse? errorResponse = await validationLayer.Delete(id);
            if (errorResponse != null)
                return TypedResults.BadRequest(errorResponse);

            return TypedResults.NoContent();
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PhysiqueDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [HttpPut("Physique/{id}")]
        public async Task<IResult> UpdatePhysique(int? id, [FromBody] PhysiqueDTO physiqueDTO, [FromServices] IValidationLayer<PhysiqueDTO> validationLayer)
        {
            (ErrorResponse? errorResponse, PhysiqueDTO? dto) = await validationLayer.Put(id, physiqueDTO);

            if (errorResponse != null)
                return TypedResults.BadRequest(errorResponse);
            else
                return TypedResults.Ok(dto);
        }
    }
}
