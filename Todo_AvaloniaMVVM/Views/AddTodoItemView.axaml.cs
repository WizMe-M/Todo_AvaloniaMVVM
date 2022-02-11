using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Todo_AvaloniaMVVM.Views;

public partial class AddTodoItemView : UserControl
{
    public AddTodoItemView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}