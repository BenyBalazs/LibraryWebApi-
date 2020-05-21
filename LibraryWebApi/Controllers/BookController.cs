using System.Collections.Generic;
using LibraryWebApi.Models;
using LibraryWebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApi.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<Reader>> Get()
        {
            return Ok(BookRephository.GetAllBooks());
        }

        [HttpGet("{id}")]
        public ActionResult<Book> Get(long id)
        {
            var book = BookRephository.GetBookById(id);

            if (book != null)
                return Ok(book);
            else
                return NotFound();
        }
        [HttpPost]
        public ActionResult Post(Book book)
        {
            BookRephository.AddBook(book);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(Book book, long id)
        {
            var dbBook = BookRephository.GetBookById(id);
            if (dbBook != null)
            {
                BookRephository.UpdateBook(book);
                return Ok();
            }
            else
                return NotFound();

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var dbBook = BookRephository.GetBookById(id);
            if (dbBook != null)
            {
                BookRephository.DeleteBook(dbBook);
                return Ok();
            }
            else
                return NotFound();

        }
    }

}