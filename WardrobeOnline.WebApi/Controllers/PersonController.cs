using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WardrobeOnline.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetUserPersonsIDs(int token)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public JsonResult GetPersonInfo(int id, int? token = null)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public JsonResult DeletePerson(int token, int id) 
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public JsonResult CreatePerson(int token, int id) 
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public JsonResult UpdatePersonInfo(int token, int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public JsonResult GetPersonComplections(int id, int token)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public JsonResult CreateComplection(int token)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public JsonResult DeleteComplection(int id, int token)
        {
            throw new NotImplementedException();
        }

        public JsonResult UpdateComplection(int id, int token)
        {
            throw new NotImplementedException();
        }

       
    }
}
