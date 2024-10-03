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

}