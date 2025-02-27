namespace AppdaSorteOficial;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGererateLuckNumbers(object sender, EventArgs e)
	{
        NomeAPP.IsVisible = false;
        ConteinerNumeros.IsVisible = true;

		var set = GerarNumeros();

		numero01.Text = set.ElementAt(0).ToString("D2");
		numero02.Text = set.ElementAt(1).ToString("D2");
		numero03.Text = set.ElementAt(3).ToString("D2");
		numero04.Text = set.ElementAt(4).ToString("D2");
        numero05.Text = set.ElementAt(5).ToString("D2");
        numero06.Text = set.ElementAt(5).ToString("D2");
        numero07.Text = set.ElementAt(7).ToString("D2");
    }
	private static SortedSet<int> GerarNumeros()
	{
      
		var set= new SortedSet<int>(); //Criei uma lista 

        //HashSet
        //
        while (set.Count<6)
		{
			var random = new Random(); //Instanciando a Classe Random
			var luckNumber = random.Next(1,60);

			set.Add(luckNumber);
		};
		return set;

        


    }

	
}