namespace FilmFinderXUI;

public partial class Search : ContentPage
{
    public Search()
    {
        InitializeComponent();
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
