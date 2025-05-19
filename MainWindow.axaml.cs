using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Threading.Tasks;

namespace ProjectAstraApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowWelcomeScreen();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private async void ShowWelcomeScreen()
        {
            var mainContent = this.FindControl<ContentControl>("MainContent");
            var welcomeView = new WelcomeView();
            mainContent.Content = welcomeView;

            // Espera 3 segundos e troca para menu
            await Task.Delay(3000);

            var menuView = new MenuView();
            mainContent.Content = menuView;
        }
    }
}
