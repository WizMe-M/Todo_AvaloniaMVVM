using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Todo_AvaloniaMVVM.Services;
using Todo_AvaloniaMVVM.ViewModels;

namespace Todo_AvaloniaMVVM.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(new StubDatabase());
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}