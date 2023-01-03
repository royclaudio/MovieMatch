using FilmFinderXUI.DataServices;
namespace FilmFinderXUI;

public partial class Recommended : ContentPage
{
    private readonly IRestDataService _dataService;

    public Recommended(IRestDataService dataService)
    {
		InitializeComponent();
        _dataService = dataService;

    }
    protected async override void OnAppearing()
    {
        base.OnAppearing();
        // movies = _dataService.GetMoviesAsync();
    }
    async void SavePopup(object sender, EventArgs e)
    {
        string action = await DisplayActionSheet("Save Movie", "Cancel", "Like", "Interested");
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
    }
}
