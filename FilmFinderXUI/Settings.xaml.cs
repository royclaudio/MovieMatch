namespace FilmFinderXUI;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
        backbtnlabel.TranslateTo(backbtn.X,0,500);
	}
    async void Back(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new Profile());
    }
    
}
