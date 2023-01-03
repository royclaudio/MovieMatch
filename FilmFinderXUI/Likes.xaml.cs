namespace FilmFinderXUI;

public partial class Likes : ContentPage
{
	public Likes()
	{
		InitializeComponent();
	}
    async void Settings(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new Settings());
    }
}
