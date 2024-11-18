namespace AppEventos.Views;

public partial class Confirmacao : ContentPage
{
	public Confirmacao()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Evento Salvo com sucesso!","Seu Evento foi salvo e enviado para aprovação", "Ok");
    }
}