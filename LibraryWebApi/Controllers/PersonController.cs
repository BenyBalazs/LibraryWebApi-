using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryWebApi.Models;
using LibraryWebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApi.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<Reader>> Get()
        {
            return Ok(ReaderRephository.GetAllUsers());
        }

        [HttpGet("{id}")]
        public ActionResult<Reader> Get(long id)
        {
            var user = ReaderRephository.GetUserById(id);

            if (user != null)
                return Ok(user);
            else
                return NotFound();
        }
        [HttpPost]
        public ActionResult Post(Reader person)
        {
            ReaderRephository.AddUser(person);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(Reader user, long id)
        {
            var dbuser = ReaderRephository.GetUserById(id);
            if (dbuser != null)
            {
                ReaderRephository.UpdateUser(user);
                return Ok();
            }
            else
                return NotFound();

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var user = ReaderRephository.GetUserById(id);
            if (user != null)
            {
                ReaderRephository.DeleteUser(user);
                return Ok();
            }
            else
                return NotFound();
            
        }
    }
}