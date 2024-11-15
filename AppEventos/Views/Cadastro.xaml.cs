using AppEventos.Models;

namespace AppEventos.Views;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
		InitializeComponent();

        dt_ini.MinimumDate = DateTime.Now;
        dt_ter.MaximumDate = new DateTime( DateTime.Now.Year);


    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {

     

		try
		{
            
            Dados d = new Dados
            {
                DataIni = dt_ini.Date,
                DataTermino = dt_ter.Date,
                NumParticipantes = Convert.ToInt32(num_part),
                Custo = Convert.ToInt32(custo_part),

            };
            
           await Navigation.PushAsync(new Confirmacao()
           {
               BindingContext = d
           });
		} catch(Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "Ok");
		}
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
            Navigation.PopAsync();
        } catch(Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Ok");
		}		
    }
}