using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WardrobeOnline.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetPersonSets(int id, int token)
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public JsonResult GetSetInfo(int id)
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public JsonResult GetSetClothes(int id)
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        public JsonResult DeleteSet(int id)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public JsonResult CreateSet(int id)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public JsonResult PostNewCloth(int id)
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        public JsonResult RemoveCloth(int id)
        {
            throw new NotImplementedException();
        }
    }
}
