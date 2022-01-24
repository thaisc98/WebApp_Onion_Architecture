using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet(nameof(GetAllBooks))]
        public IActionResult GetAllBooks()
        {
            var res = _bookService.GetAllBooks();
            if (res is not null)
            {
                return Ok(res);
            }

            return BadRequest("Not found books");
        }

        [HttpGet(nameof(GetBook))]
        public IActionResult GetBook(int id)
        {
            var res = _bookService.GetBook(id);
            if (res is not null)
            {
                return Ok(res);
            }

            return BadRequest("Not found the book");
        }

        [HttpPost(nameof(InsertBook))]
        public IActionResult InsertBook(Book book)
        {
            _bookService.InsertBook(book);
            return Ok("Book saved");
        }

        [HttpPut(nameof(UpdateBook))]
        public IActionResult UpdateBook(Book book)
        {
            _bookService.UpdateBook(book);
            return Ok("Book updated");
        }

        [HttpDelete(nameof(DeleteBook))]
        public IActionResult DeleteBook(int id)
        {
            _bookService.DeleteBook(id);
            return Ok("Book deleted");
        }
    }
}
