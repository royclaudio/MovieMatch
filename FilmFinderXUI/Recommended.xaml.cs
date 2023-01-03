namespace FilmFinderXUI;

public partial class Recommended : ContentPage
{
	public Recommended()
	{
		InitializeComponent();
	}
    async void SavePopup(object sender, EventArgs e)
    {
        string action = await DisplayActionSheet("Save Movie", "Cancel", "Like", "Interested");
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
    }
}
