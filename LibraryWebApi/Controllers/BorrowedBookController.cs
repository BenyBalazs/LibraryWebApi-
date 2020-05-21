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
    [Route("api/borrowedbooks")]
    [ApiController]
    public class BorrowedBookController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<BorrowedBook>> Get()
        {
            var List = BorrowedBookRephository.GetAllBorrowedBooks();
            return Ok(List);
        }

        [HttpGet("{id}")]
        public ActionResult<BorrowedBook> GetBorrowedBookId(long id)
        {
            var borrowedBook = BorrowedBookRephository.GetByBorrowedBookId(id);

            if (borrowedBook != null)
                return Ok(borrowedBook);
            else
                return NotFound();
        }
        [HttpPost]
        public ActionResult Post(BorrowedBook borrowedBook)
        {
            BorrowedBookRephository.AddNewBorrow(borrowedBook);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(BorrowedBook borrowedBook, long id)
        {
            var dbBorrowedBook = BorrowedBookRephository.GetByBorrowedBookId(id);
            if (dbBorrowedBook != null)
            {
                BorrowedBookRephository.UpdateBorrw(borrowedBook);
                return Ok();
            }
            else
                return NotFound();

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var dbBorrowedBook = BorrowedBookRephository.GetByBorrowedBookId(id);
            if (dbBorrowedBook != null)
            {
                BorrowedBookRephository.DeleteBorrow(dbBorrowedBook);
                return Ok();
            }
            else
                return NotFound();

        }
    }
}