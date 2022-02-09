using System;
using System.Collections.Generic;
using System.Text;
using Todo_AvaloniaMVVM.Services;

namespace Todo_AvaloniaMVVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(StubDatabase database)
        {
            List = new TodoListViewModel(database.GetItems());
        }

        public TodoListViewModel List { get; }
    }
}