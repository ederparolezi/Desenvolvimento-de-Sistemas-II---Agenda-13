
namespace Agenda13Sobre;

// Classe responsável pela tela principal
public partial class MainPage : ContentPage
{
    // Construtor da tela
    public MainPage()
    {
        InitializeComponent();

        // Preenche a lista de suítes
        pck_quarto.ItemsSource = new List<SuiteOpcao>
        {
            new SuiteOpcao { Descricao = "Suíte Super Luxo" },
            new SuiteOpcao { Descricao = "Suíte Luxo" },
            new SuiteOpcao { Descricao = "Suíte Single" },
            new SuiteOpcao { Descricao = "Suíte Crise" }
        };

        // Configura o período permitido para check-in
        dtpck_checkin.MinimumDate = DateTime.Today;
        dtpck_checkin.MaximumDate = DateTime.Today.AddMonths(1);

        // Recupera a data de check-in
        DateTime checkin =
            dtpck_checkin.Date ?? DateTime.Today;

        // Configura as datas de check-out
        dtpck_checkout.MinimumDate = checkin.AddDays(1);
        dtpck_checkout.MaximumDate = checkin.AddMonths(6);

        // Define o check-out para o dia seguinte
        dtpck_checkout.Date = checkin.AddDays(1);
    }

    // Atualiza o check-out quando o check-in mudar
    private void dtpck_checkin_DateSelected(
        object? sender,
        DateChangedEventArgs e)
    {
        DateTime checkin =
            dtpck_checkin.Date ?? DateTime.Today;

        dtpck_checkout.MinimumDate = checkin.AddDays(1);
        dtpck_checkout.MaximumDate = checkin.AddMonths(6);

        // Corrige o check-out se necessário
        if (dtpck_checkout.Date == null ||
            dtpck_checkout.Date < checkin.AddDays(1))
        {
            dtpck_checkout.Date = checkin.AddDays(1);
        }
    }

    // Abre a segunda tela: Sobre
    private async void Sobre_Clicked(
        object? sender,
        EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}

// Classe simples para apresentar as suítes no Picker
public class SuiteOpcao
{
    public string Descricao { get; set; } = "";
}
