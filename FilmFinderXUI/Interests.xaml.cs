namespace FilmFinderXUI;

public partial class Interests : ContentPage
{
	public Interests()
	{
		InitializeComponent();
	}
    async void Settings(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new Settings());
    }
}
