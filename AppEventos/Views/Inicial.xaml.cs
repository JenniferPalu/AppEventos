namespace AppEventos.Views;

public partial class Inicial : ContentPage
{
	public Inicial()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

		try
		{
			Navigation.PushAsync(new Cadastro());
		}catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Ok");
		}
    }
}