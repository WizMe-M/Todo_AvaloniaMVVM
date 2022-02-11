using System;

namespace Todo_AvaloniaMVVM.Models;

public class TodoItem
{
    public string Description { get; set; } = null!;
    public DateTime DueDate { get; set; }
    public bool IsChecked { get; set; }
}