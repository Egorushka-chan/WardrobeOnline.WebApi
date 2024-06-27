using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("PersonInfo/{id}")]
        public IResult GetPersonInfo(int id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{token}/{id}")]
        public IResult DeletePerson(int token, int id) 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Append new person to a database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="dbContext"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IResult> CreatePerson(string name, [FromServices] WardrobePostgreContext dbContext) 
        {
            if (string.IsNullOrEmpty(name))
            {
                return Results.BadRequest(new
                {
                    name = "Incorrect name"
                });
            }

            Person person = new Person()
            {
                Name = name
            };
            dbContext.Persons.Add(person);
            await dbContext.SaveChangesAsync();
            return TypedResults.Ok(person);
        }

        [HttpPost("update/{token}/{id}")]
        public IResult UpdatePersonInfo(int token, int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("complection/{token}/{id}")]
        public IResult GetPersonComplections(int id, int token)
        {
            throw new NotImplementedException();
        }

        [HttpPost("complection/{token}")]
        public IResult CreateComplection(int token)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("complection/{id}/{token}")]
        public IResult DeleteComplection(int id, int token)
        {
            throw new NotImplementedException();
        }
        [HttpPost("complection/update/{id}/{token}")]
        public IResult UpdateComplection(int id, int token)
        {
            throw new NotImplementedException();
        }

       
    }
}
