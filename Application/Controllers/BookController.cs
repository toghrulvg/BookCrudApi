using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Book;
using Service.Services.Interfaces;

namespace Application.Controllers
{
    
    public class BookController : AppController
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService; 
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] BookCreateDTO book)
        {
            await _bookService.CreateAsync(book);
            return Ok();
        }
        


    }
}
