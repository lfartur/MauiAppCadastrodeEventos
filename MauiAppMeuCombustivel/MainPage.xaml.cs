using CadastroDeEventos.Models;
using CadastroDeEventos.Views;

namespace CadastroDeEventos;

public partial class MainPage : ContentPage
{
    public Command CadastrarEventoCommand { get; }

    public MainPage()
    {
        InitializeComponent();
        CadastrarEventoCommand = new Command(CadastrarEvento);
        BindingContext = this;
    }

    private async void CadastrarEvento()
    {
        var evento = (Evento)BindingContext;
        await Navigation.PushAsync(new ResumoPage(evento));
    }
}


}
