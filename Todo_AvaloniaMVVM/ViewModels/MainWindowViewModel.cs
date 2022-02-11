using System;
using System.Reactive.Linq;
using ReactiveUI;
using Todo_AvaloniaMVVM.Models;
using Todo_AvaloniaMVVM.Services;

namespace Todo_AvaloniaMVVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _content;

        public MainWindowViewModel(StubDatabase database)
        {
            Content = List = new TodoListViewModel(database.GetItems());
        }

        public TodoListViewModel List { get; }

        public ViewModelBase Content
        {
            get => _content;
            private set => this.RaiseAndSetIfChanged(ref _content, value);
        }

        public void AddItem()
        {
            var vm = new AddTodoItemViewModel();

            Observable.Merge(vm.Ok, vm.Cancel.Select(_ => (TodoItem)null!))
                .Take(1)
                .Subscribe(model =>
                {
                    if (model != null)
                    {
                        List.Items.Add(model);
                    }

                    Content = List;
                }); 

            Content = vm;
        }
    }
}