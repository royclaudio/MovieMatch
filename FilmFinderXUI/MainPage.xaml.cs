using FilmFinderXUI.DataServices;
using Microsoft.Maui.ApplicationModel.DataTransfer;
using FilmFinderXUI.Models;
namespace FilmFinderXUI;

public partial class MainPage : ContentPage
{
    private readonly IRestDataService _dataService;

    //int count = 0;
    public MainPage(IRestDataService dataService)
    {
        InitializeComponent();
        _dataService = dataService;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        // movies = _dataService.GetMoviesAsync();
    }


    //private void Search(object sender, EventArgs e)
    //{
    //    Navigation.PushAsync(new Search(_dataService));
    //}

    void OnSwiped(object sender, SwipedEventArgs e)
    {
        
        switch (e.Direction)
        {
            case SwipeDirection.Left:
                // Handle the swipe
                //box.TranslateTo(-100,0, 500);
                moviecard.TranslateTo(-200, 0, 250);
                moviecard.FadeTo(0.5, 250);
               

                break;
            case SwipeDirection.Right:
                // Handle the swipe
                //box.TranslateTo(100, 0, 500);
                moviecard.TranslateTo(200, 0, 250);
                moviecard.FadeTo(0.5, 250);

                // opp = now.Second / 59;
                //moviecard.Opacity = opp;
                break;
            case SwipeDirection.Up:
                // Handle the swipe
                moviecard.TranslateTo(0, 0, 0);
                moviecard.FadeTo(1, 0);
                break;
            case SwipeDirection.Down:
                // Handle the swipe
                break;
            default:
                moviecard.TranslateTo(0, 0, 100);
                moviecard.FadeTo(1, 100);
                break;
        }
        if (moviecard.TranslationX == -200
                    || moviecard.TranslationX == 200
                    )
        {
            moviecard.FadeTo(1, 250);
            moviecard.TranslateTo(0, 0, 250, Easing.CubicIn);
        }
    }
    private void DragGestureRecognizer_DragStarting_1(object sender, DragStartingEventArgs e)
    {
        var label = (sender as Element)?.Parent as Label;
        e.Data.Properties.Add("Text", label.Text);
    }

    private void DropGestureRecognizer_Drop_1(object sender, DropEventArgs e)
    {
        var data = e.Data.Properties["Text"].ToString();
        var frame = (sender as Element)?.Parent as Frame;
        frame.Content = new Label
        {
            Text = data
        };
    }
}


