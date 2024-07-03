using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WardrobeOnline.WebApi.Controllers
{
    /// <summary>
    /// Пока только заглушки
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ClothesController : ControllerBase
    {
        // TODO: Чё-то к пятнице работать должно
        [HttpGet("Person/{id}")]
        public IResult GetPersonClothes(int id)
        {
            throw new NotImplementedException();
        }
        [HttpGet("{id}")]
        public IResult GetCloth(int id)
        {
            throw new NotImplementedException();
        }
        [HttpPost("Add/{name}")]
        public IResult AddCloth(string name)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Update/{id}")]
        public IResult UpdateCloth(int id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IResult DeleteCloth(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Photo/{id}")]
        public IResult PostPhoto(int id)
        {
            throw new NotImplementedException();
        }
    }
}
