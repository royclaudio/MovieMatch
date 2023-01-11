using FilmFinderXUI.DataServices;
using FilmFinderXUI.Models;
namespace FilmFinderXUI;

public partial class Recommended : ContentPage
{
    private readonly IRestDataService _dataService;
    public IEnumerable<MovieCatalogModel> items;
    public Recommended(IRestDataService dataService)
    {
		InitializeComponent();
        _dataService = dataService;
        //collectionView.SetBinding(ItemsView.ItemsSourceProperty, "MovieCatalogModel");

        //items = (IEnumerable<Models.MovieCatalogModel>)_dataService.GetMoviesAsync();
    }
    protected async override void OnAppearing()
    {
        base.OnAppearing();
        //items = (IEnumerable<Models.MovieCatalogModel>)_dataService.GetMoviesAsync();
        collectionView.ItemsSource = await _dataService.GetMoviesAsync();
        //collectionView.SetBinding(ItemsView.ItemsSourceProperty, "MovieCatalogModel");
    }
    async void SavePopup(object sender, EventArgs e)
    {
        string action = await DisplayActionSheet("Save Movie", "Cancel", "Like", "Interested");
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
    }
}
