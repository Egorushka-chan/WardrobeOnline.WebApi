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
        [HttpPost("Create")]
        public async Task<IResult> CreatePerson(string name, [FromServices] WardrobeContext dbContext) 
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

        [HttpGet("physique/{token}/{id}")]
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
