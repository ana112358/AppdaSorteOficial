namespace AppdaSorteOficial;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	private void GerarNumeros(object sender, EventArgs e)
	{
		NomeAPP.IsVisible = false;
		ConteinerNumeros.IsVisible = true;
	}
	
}