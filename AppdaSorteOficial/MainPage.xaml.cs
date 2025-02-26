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

        var random = new Random();
        var numerosSorte = new HashSet<int>();

        while (numerosSorte.Count < 7)
        {
            numerosSorte.Add(random.Next(1, 61));  // Números de 1 a 60
        }

  
        var numeroArray = new int[7];
        numerosSorte.CopyTo(numeroArray);

        numero01.Text = numeroArray[0].ToString("D2");
        numero02.Text = numeroArray[1].ToString("D2");
        numero03.Text = numeroArray[2].ToString("D2");
        numero04.Text = numeroArray[3].ToString("D2");
        numero05.Text = numeroArray[4].ToString("D2");
        numero06.Text = numeroArray[5].ToString("D2");
        numero07.Text = numeroArray[6].ToString("D2");


    }
	
}