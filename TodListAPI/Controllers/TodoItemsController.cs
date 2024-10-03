using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;   
using Models;

namespace TodListAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class TodoItemsController : ControllerBase
{
    private readonly TodoDbContext _context;
    public TodoItemsController(TodoDbContext context){
        _context =  context;
    }
    [HttpGet]
    public IActionResult Get()
    {
        var todoItems = _context.TodoItems.Where( item => item.CompletedDate == null).ToList();
        return Ok(todoItems);
    }
    [HttpGet("{id}")]
    public IActionResult GetbyId(int id)
    {
        var todoItems = _context.TodoItems.FirstOrDefault( item => item.Id == id);
        if (todoItems == null)
        {
            return NotFound();
        }
        return Ok(todoItems);
    }
    [HttpPost]
        public IActionResult CreatePost([FromBody] TodoItem todoItem)
        {
            _context.TodoItems.Add(todoItem);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetbyId), new {id = todoItem.Id}, todoItem);
    }
    [HttpPost]
        public IActionResult CompleteDate(int id)
        {
        var todoItems = _context.TodoItems.FirstOrDefault( item => item.Id == id);
        if (todoItems == null)
        {
            return NotFound();
        }
        todoItems.CompletedDate = DateTime.Now;
        _context.SaveChanges();
        return Ok(todoItems);
        }
}