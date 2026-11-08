
namespace Agenda13Sobre;

// Classe responsável pela tela Sobre
public partial class Sobre : ContentPage
{
    // Construtor da página
    public Sobre()
    {
        // Carrega a interface Sobre.xaml
        InitializeComponent();
    }

    // Evento do botão Voltar
    private async void Voltar_Clicked(
        object? sender,
        EventArgs e)
    {
        // Retorna à tela Cálculo da Diária
        await Navigation.PopAsync();
    }
}
