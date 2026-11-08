
namespace Agenda13Sobre;

public partial class App : Application
{
    // Construtor principal do aplicativo
    public App()
    {
        InitializeComponent();
    }

    // Define a tela inicial no .NET MAUI 10
    protected override Window CreateWindow(
        IActivationState? activationState)
    {
        // Cria uma estrutura de navegação
        // e apresenta a tela Cálculo da Diária
        return new Window(
            new NavigationPage(
                new MainPage()
            )
        );
    }
}
