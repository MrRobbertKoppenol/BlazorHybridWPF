using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

namespace BlazorHybridWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddMudServices();
#if DEBUG
            serviceCollection.AddBlazorWebViewDeveloperTools();
#endif
            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }
}