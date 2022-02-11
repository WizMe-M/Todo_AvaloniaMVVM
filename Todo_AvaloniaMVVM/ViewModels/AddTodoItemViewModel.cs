using System.Reactive;
using ReactiveUI;
using Todo_AvaloniaMVVM.Models;

namespace Todo_AvaloniaMVVM.ViewModels;

public class AddTodoItemViewModel : ViewModelBase
{
    private string _description;

    public AddTodoItemViewModel()
    {
        var okButtonEnabled = this.WhenAnyValue(
            x => x.Description,
            x => !string.IsNullOrWhiteSpace(x));

        Ok = ReactiveCommand.Create(() => new TodoItem { Description = Description }, okButtonEnabled);
        Cancel = ReactiveCommand.Create(() => { });
    }

    public string Description
    {
        get => _description;
        set => this.RaiseAndSetIfChanged(ref _description, value);
    }

    public ReactiveCommand<Unit, TodoItem> Ok { get; }
    public ReactiveCommand<Unit, Unit> Cancel { get; }
}