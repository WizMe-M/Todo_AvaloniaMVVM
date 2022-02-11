using System;
using System.Reactive;
using ReactiveUI;
using Todo_AvaloniaMVVM.Models;

namespace Todo_AvaloniaMVVM.ViewModels;

public class AddTodoItemViewModel : ViewModelBase
{
    private string _description;
    private DateTime _dueDate;

    public AddTodoItemViewModel()
    {
        var okButtonEnabled = this.WhenAnyValue(
            viewModel => viewModel.Description,
            value => !string.IsNullOrWhiteSpace(value));

        Ok = ReactiveCommand.Create(() => new TodoItem
        {
            Description = Description,
            DueDate = DueDate == new DateTime() ? DateTime.Today : DueDate
        }, okButtonEnabled);
        Cancel = ReactiveCommand.Create(() => { });
    }

    public string Description
    {
        get => _description;
        set => this.RaiseAndSetIfChanged(ref _description, value);
    }

    public DateTime DueDate
    {
        get => _dueDate;
        set => this.RaiseAndSetIfChanged(ref _dueDate, value);
    }

    public ReactiveCommand<Unit, TodoItem> Ok { get; }
    public ReactiveCommand<Unit, Unit> Cancel { get; }
}