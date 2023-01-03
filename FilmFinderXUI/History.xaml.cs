namespace FilmFinderXUI;

public partial class History : ContentPage
{
	public History()
	{
		InitializeComponent();
	}
    async void Settings(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new Settings());
    }
}
