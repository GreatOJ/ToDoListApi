﻿namespace Models;

public class TodoItem
{
    public int Id {get; set;}
    public string? Description {get; set; }
    public DateTime DueDate{get; set;}
    public DateTime CompletedDate{get; set;}
}
