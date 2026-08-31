using CVCEntregas.Mobile.Models;

namespace CVCEntregas.Mobile.Views;

public partial class ListaEntregasPage : ContentPage
{
    public List<Entrega> ListaDeEntregas { get; set; }

    public ListaEntregasPage()
    {
        InitializeComponent();
        CarregarEntregasMock();
    }

    private void CarregarEntregasMock()
    {
        // Dados temporários para testar a interface
        ListaDeEntregas = new List<Entrega>
        {
            new Entrega { Id = 1, ClienteNome = "Depósito Constrular", DescricaoItens = "200 Tijolos cerâmicos (9x19)", Endereco = "Rua das Flores, 123 - Centro", Status = "Pendente" },
            new Entrega { Id = 2, ClienteNome = "Obra Silva & Santos", DescricaoItens = "2m³ Areia Fina (Granel)", Endereco = "Av. Paulista, 1500 - Bela Vista", Status = "Pendente" },
            new Entrega { Id = 3, ClienteNome = "Marcos Construtor", DescricaoItens = "50 Pacotes de Tijolo Comum", Endereco = "Rua do Comércio, 45 - Industrial", Status = "Entregue" }
        };

        CvEntregas.ItemsSource = ListaDeEntregas;
    }

    private async void OnAbrirMapsClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var entrega = button?.BindingContext as Entrega;

        if (entrega != null)
        {
            // Integração nativa com Google Maps / Waze
            var enderecoEscapado = Uri.EscapeDataString(entrega.Endereco);
            var uri = new Uri($"https://www.google.com/maps/search/?api=1&query={enderecoEscapado}");
            await Launcher.Default.OpenAsync(uri);
        }
    }

    private async void OnConcluirEntregaClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var entrega = button?.BindingContext as Entrega;

        if (entrega != null)
        {
            bool confirmar = await DisplayAlert("Confirmação", $"Deseja marcar a entrega do {entrega.ClienteNome} como Concluída?", "Sim", "Não");
            if (confirmar)
            {
                entrega.Status = "Entregue";
                CarregarEntregasMock(); // Recarrega a lista visualmente
            }
        }
    }

    private async void OnNovoPedidoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NovaEntregaPage());
    }
}
