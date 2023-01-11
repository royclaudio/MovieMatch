using Microsoft.Maui.Controls;

namespace FilmFinderXUI;

public partial class Search : ContentPage
{
    private readonly DataServices.IRestDataService _dataService;

    public Search(DataServices.IRestDataService dataService)
    {
        InitializeComponent();
        _dataService = dataService;

    }
    protected async override void OnAppearing()
    {
        base.OnAppearing();
        //items = (IEnumerable<Models.MovieCatalogModel>)_dataService.GetMoviesAsync();
        collectionView.ItemsSource = await _dataService.GetMoviesAsync();
        //collectionView.SetBinding(ItemsView.ItemsSourceProperty, "MovieCatalogModel");
    }
    void OnScrollViewScrolled(object sender, ScrolledEventArgs e)
    {
        Console.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");
    }
    async void SavePopup(object sender, EventArgs e)
    {
        string action = await DisplayActionSheet("Save Movie", "Cancel", "Like", "Interested");
    }

}
