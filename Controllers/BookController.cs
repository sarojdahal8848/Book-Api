using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using simple_crud.Dto;
using simple_crud.Interfaces;
using simple_crud.Models;

namespace simple_crud.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IImageStorageRepository _imageStorageRepository;
        private readonly IMapper _mapper;
        public BookController(IBookRepository bookRepository, IMapper mapper, IImageStorageRepository imageStorageRepository)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
            _imageStorageRepository = imageStorageRepository;

        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<BookDto>))]
        public async Task<IActionResult> Get()
        {
            var books = _mapper.Map<List<BookDto>>(await _bookRepository.GetBooks());
            return Ok(books);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(BookDto))]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Get(int id)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var book = await _bookRepository.GetBookById(id);
            if(book == null)
                return NotFound();

            var bookResult = _mapper.Map<BookDto>(book);
            return Ok(bookResult);
        }

        [HttpPost]
        [ProducesResponseType(201, Type = typeof(BookDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Post([FromForm] CreateBookDto bookDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            if(bookDto.Image == null)
                return BadRequest("No image uploaded.");


            var book = _mapper.Map<Book>(bookDto);

            var imagePath = await _imageStorageRepository.SaveImage(bookDto.Image);
            book.ImagePath = imagePath;

            await _bookRepository.CreateBook(book);

            var createdBook = _mapper.Map<BookDto>(book);
            return CreatedAtAction("Get", new { id = createdBook.Id }, createdBook);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Put(int id, [FromForm] CreateBookDto bookDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var book = await _bookRepository.GetBookById(id);

            if(book == null)
                return NotFound();

            var bookMap = _mapper.Map<Book>(bookDto);
            var imagePath = await _imageStorageRepository.SaveImage(bookMap.Image);

            bookMap.ImagePath = imagePath;
            await _bookRepository.UpdateBook(id, bookMap);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]

        public async Task<IActionResult> Delete(int id)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var book = await _bookRepository.GetBookById(id);
            if(book == null)
                return NotFound();

            await _bookRepository.DeleteBook(id);

            return NoContent();
        }
    }
}