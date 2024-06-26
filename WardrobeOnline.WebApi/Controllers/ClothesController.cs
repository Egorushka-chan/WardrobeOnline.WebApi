using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WardrobeOnline.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetPersonClothes(int id, int token)
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public JsonResult GetCloth(int id, int token)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public JsonResult UpdateCloth(int id, int token)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public JsonResult DeleteCloth(int id, int token)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public JsonResult PostPhoto(int id, int token)
        {
            throw new NotImplementedException();
        }
    }
}
