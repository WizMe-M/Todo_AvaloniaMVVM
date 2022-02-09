using System.Collections.Generic;
using Todo_AvaloniaMVVM.Models;

namespace Todo_AvaloniaMVVM.Services;

public class StubDatabase
{
    public IEnumerable<TodoItem> GetItems() => new[]
    {
        new TodoItem { Description = "Do my practice works to next Monday", IsChecked = true },
        new TodoItem { Description = "Play DnD with my friends this Friday", IsChecked = false },
        new TodoItem { Description = "Learn Avalonia", IsChecked = false }
    };
}