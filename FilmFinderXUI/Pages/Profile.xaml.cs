using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using FilmFinderXUI.DataServices;

namespace FilmFinderXUI;

public partial class Profile : ContentPage
{
    public StackLayout currentLayout;
    public double deltaStart;
    public double deltaCenter;
    public double deltaEnd;
    public int position = 0;
    private readonly IRestDataService _dataService;
    //public IEnumerable<Models.MovieCatalogModel> items;
    public Profile(IRestDataService dataService)
    {
        InitializeComponent();
       

        _dataService = dataService;
        //items = (IEnumerable<Models.MovieCatalogModel>)_dataService.GetMoviesAsync();
    }
    async void Settings(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new Settings());
    }
    async void SavePopup(object sender, EventArgs e)
    {
        string action = await DisplayActionSheet("Seen Movie", "Cancel", "Liked", "Disliked");
    }
    StackLayout LikedLayout()
    {
        Grid MainGrid = new Grid
        {
            RowDefinitions = { new RowDefinition { Height = GridLength.Auto } },
            ColumnDefinitions ={
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }},
        };
        MainGrid.Add(new Border
        {
            MinimumHeightRequest = 200,
            MaximumHeightRequest = 200,
            Stroke = Colors.Transparent,
            Content = new Image
            {
                Source = new UriImageSource
                {
                    Uri = new Uri("https://i.ebayimg.com/images/g/a2wAAOxyP4dTeYQ7/s-l1600.jpg"),
                    CacheValidity = new TimeSpan(10, 0, 0, 0)
                }
            }
        }, 0, 0);

        var MoreInfoBtn = new Button
        {
            Text = "More Info",
            ImageSource = "showlove.png",
            BackgroundColor = Colors.Transparent,
            HorizontalOptions = LayoutOptions.Center,
            ContentLayout = new Button.ButtonContentLayout(Button.ButtonContentLayout.ImagePosition.Top, 0),
            BorderWidth = 0,
            FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
            TextColor = Colors.Black
        };
        var ShareBtn = new Button
        {
            Text = "Share",
            ImageSource = "user.png",
            BackgroundColor = Colors.Transparent,
            HorizontalOptions = LayoutOptions.Center,
            ContentLayout = new Button.ButtonContentLayout(Button.ButtonContentLayout.ImagePosition.Top, 0),
            BorderWidth = 0,
            FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
            TextColor = Colors.Black
        };

        // button grid
        Grid BtnGrid = new Grid
        {
            ColumnDefinitions ={
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }},
        };
        BtnGrid.Add(MoreInfoBtn, 0, 0);
        BtnGrid.Add(ShareBtn, 1, 0);
        // actor director grid
        Grid infoGrid = new Grid
        {
            RowDefinitions = {
                                new RowDefinition { Height = GridLength.Auto },
                                new RowDefinition { Height = GridLength.Auto },
                                new RowDefinition { Height = 10 },
                                new RowDefinition { Height = GridLength.Auto },
                                new RowDefinition { Height = GridLength.Auto }
                            },
            ColumnDefinitions ={
                                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                                new ColumnDefinition { Width = GridLength.Auto }
                                },

        };
        var directors = new Label
        {
            Text = "Directed by",
        };
        var directorlist = new Label
        {
            Text = "Sam Raimi",
            FontSize = 12
        };
        var boxline = new BoxView
        {
            Color = Colors.Black,
            HeightRequest = 2,
            HorizontalOptions = LayoutOptions.Fill
        };
        var actors = new Label
        {
            Text = "Stars",
        };
        var actorlist = new Label
        {
            Text = "Tobey Maguire",
            FontSize = 12,
        };
        infoGrid.Add(directors, 0, 0);
        infoGrid.Add(directorlist, 1, 1);
        infoGrid.Add(boxline, 0, 2);
        infoGrid.SetColumnSpan(boxline, 2);

        infoGrid.Add(actors, 0, 3);
        infoGrid.Add(actorlist, 1, 4);
        // Info 
        MainGrid.Add(new VerticalStackLayout
        {
            Children = {
                            new Label
                            {
                                Text = "Liked",
                                FontAttributes = FontAttributes.Bold,
                                HorizontalOptions = LayoutOptions.Center
                            },
                            new BoxView
                            {
                                Color = Colors.Black,
                                HeightRequest = 2,
                                HorizontalOptions = LayoutOptions.Fill
                            },
                            new Label
                            {
                                Text = "Action, Adventure",
                                FontAttributes = FontAttributes.Bold,
                                FontSize = 12,
                                HorizontalOptions = LayoutOptions.Center
                            },
                            new BoxView
                            {
                                Color = Colors.Black,
                                HeightRequest = 2,
                                HorizontalOptions = LayoutOptions.Fill
                            },
                            new Border
                            {
                                Stroke = Colors.Transparent,
                                Content = infoGrid
                            },
                           BtnGrid,
                            new Label
                            {
                                Text = "Released 03 may 2022",
                                FontAttributes = FontAttributes.Bold,
                                HorizontalOptions = LayoutOptions.Center
                            }
                     }
        }, 1, 0);

        StackLayout currentlayout = new StackLayout();
        currentlayout.Children.Add(
            new Border
            {
                Stroke = Colors.Black,
                StrokeThickness = 4,
                BackgroundColor = Colors.White,
                StrokeShape = new RoundRectangle
                {
                    CornerRadius = new CornerRadius(10, 10, 10, 10)
                },
                Padding = new Thickness(-5, 0, 15, 0),
                Content = MainGrid
            });
        return currentlayout;
    }
    StackLayout HistoryLayout()
    {
        Grid MainGrid = new Grid
        {
            RowDefinitions = { new RowDefinition { Height = GridLength.Auto } },
            ColumnDefinitions ={
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }},
        };
        MainGrid.Add(new Border
        {
            MinimumHeightRequest = 200,
            MaximumHeightRequest = 200,
            Stroke = Colors.Transparent,
            Content = new Image
            {
                Source = new UriImageSource
                {
                    Uri = new Uri("https://m.media-amazon.com/images/M/MV5BMTg4MzMzMTY0OF5BMl5BanBnXkFtZTYwNzM3MTg2._V1_.jpg"),
                    CacheValidity = new TimeSpan(10, 0, 0, 0)
                }
            }
        }, 0, 0);

        var MoreInfoBtn = new Button
        {
            Text = "More Info",
            ImageSource = "showlove.png",
            BackgroundColor = Colors.Transparent,
            HorizontalOptions = LayoutOptions.Center,
            ContentLayout = new Button.ButtonContentLayout(Button.ButtonContentLayout.ImagePosition.Top, 0),
            BorderWidth = 0,
            FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
            TextColor = Colors.Black
        };
        var ShareBtn = new Button
        {
            Text = "Share",
            ImageSource = "user.png",
            BackgroundColor = Colors.Transparent,
            HorizontalOptions = LayoutOptions.Center,
            ContentLayout = new Button.ButtonContentLayout(Button.ButtonContentLayout.ImagePosition.Top, 0),
            BorderWidth = 0,
            FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
            TextColor = Colors.Black
        };

        // button grid
        Grid BtnGrid = new Grid
        {
            ColumnDefinitions ={
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }},

        };
        BtnGrid.Add(MoreInfoBtn, 0, 0);
        BtnGrid.Add(ShareBtn, 1, 0);
        // actor director grid
        Grid infoGrid = new Grid
        {
            RowDefinitions = {
                                new RowDefinition { Height = GridLength.Auto },
                                new RowDefinition { Height = GridLength.Auto },
                                new RowDefinition { Height = 10 },
                                new RowDefinition { Height = GridLength.Auto },
                                new RowDefinition { Height = GridLength.Auto }
                            },
            ColumnDefinitions ={
                                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                                new ColumnDefinition { Width = GridLength.Auto }
                                },

        };
        var directors = new Label
        {
            Text = "Directed by",
        };
        var directorlist = new Label
        {
            Text = "Sam Raimi",
            FontSize = 12
        };
        var boxline = new BoxView
        {
            Color = Colors.Black,
            HeightRequest = 2,
            HorizontalOptions = LayoutOptions.Fill
        };
        var actors = new Label
        {
            Text = "Stars",
        };
        var actorlist = new Label
        {
            Text = "Tobey Maguire",
            FontSize = 12,
        };
        infoGrid.Add(directors, 0, 0);
        infoGrid.Add(directorlist, 1, 1);
        infoGrid.Add(boxline, 0, 2);
        infoGrid.SetColumnSpan(boxline, 2);

        infoGrid.Add(actors, 0, 3);
        infoGrid.Add(actorlist, 1, 4);
        // Info 
        MainGrid.Add(new VerticalStackLayout
        {
            Children = {
                            new Label
                            {
                                Text = "History",
                                FontAttributes = FontAttributes.Bold,
                                HorizontalOptions = LayoutOptions.Center
                            },
                            new BoxView
                            {
                                Color = Colors.Black,
                                HeightRequest = 2,
                                HorizontalOptions = LayoutOptions.Fill
                            },
                            new Label
                            {
                                Text = "Action, Adventure",
                                FontAttributes = FontAttributes.Bold,
                                FontSize = 12,
                                HorizontalOptions = LayoutOptions.Center
                            },
                            new BoxView
                            {
                                Color = Colors.Black,
                                HeightRequest = 2,
                                HorizontalOptions = LayoutOptions.Fill
                            },
                            new Border
                            {
                                Stroke = Colors.Transparent,
                                Content = infoGrid
                            },
                           BtnGrid,
                            new Label
                            {
                                Text = "Released 03 may 2022",
                                FontAttributes = FontAttributes.Bold,
                                HorizontalOptions = LayoutOptions.Center
                            }
                     }
        }, 1, 0);

        StackLayout currentlayout = new StackLayout();
        currentlayout.Children.Add(
            new Border
            {
                Stroke = Colors.Black,
                StrokeThickness = 4,
                BackgroundColor = Colors.White,
                StrokeShape = new RoundRectangle
                {
                    CornerRadius = new CornerRadius(10, 10, 10, 10)
                },
                Padding = new Thickness(-5, 0, 15, 0),
                Content = MainGrid
            });
        return currentlayout;
    }
    async void OnSwiped(object sender, SwipedEventArgs e)
    {
        uint duration = 150;
        //uint deltaduration = 150;
        double currentposition = optionselected.X;
        double nextposition = 0;
        //var currLayout = currentLayout;

        switch (e.Direction)
        {
            case SwipeDirection.Left:
                if (position < 2)
                {
                    if (position == 1)
                    {
                        nextposition = History.X;
                        position = 2;
                    }
                    if (position == 0)
                    {
                        nextposition = liked.X;
                        position = 1;
                    }
                    await Task.WhenAll(scrollView.TranslateTo(-400, 0, duration),
                    scrollView.FadeTo(0, duration),
                    //Content.FadeTo(0, duration),
                    optionselected.TranslateTo(nextposition, 0, duration)
                    ); ;
                    await Task
                        .WhenAll(scrollView.TranslateTo(400, 0, duration));
                    if (position == 2)
                    {
                        scrollView.Content = HistoryLayout();
                        scrollView.BackgroundColor = Colors.Transparent;//Color.FromArgb("#FF6666");
                        //Content.BackgroundColor = Color.FromArgb("#FF6666");
                    }
                    if (position == 1)
                    {
                        scrollView.Content = LikedLayout();
                        scrollView.BackgroundColor = Colors.Transparent;
                        //Content.BackgroundColor = Color.FromArgb("#77DD77");
                        //scrollView.BackgroundColor = Color.FromArgb("#77DD77");
                    }
                    await Task.WhenAll(
                    scrollView.TranslateTo(0, 0, duration),
                    //Content.FadeTo(1, duration),
                    scrollView.FadeTo(1, duration));
                }
                break;
            case SwipeDirection.Right:
                if (position > 0)
                {
                    if (position == 1)
                    {
                        nextposition = interests.X;
                        position = 0;
                    }
                    if (position == 2)
                    {
                        nextposition = liked.X;
                        position = 1;
                    }
                    await Task.WhenAll(scrollView.TranslateTo(400, 0, duration),
                    scrollView.FadeTo(0, duration),
                    //Content.FadeTo(0, duration),
                    optionselected.TranslateTo(nextposition, 0, duration));
                    await Task.WhenAll(
                    scrollView.TranslateTo(-400, 0, duration));
                    if (position == 0)
                    {
                        scrollView.Content = currentLayout;
                        scrollView.BackgroundColor = Colors.Transparent;
                        //Content.BackgroundColor = Color.FromArgb("#FFC0CB");
                        //scrollView.BackgroundColor = Color.FromArgb("#FFC0CB");
                    }
                    if (position == 1)
                    {
                        scrollView.Content = LikedLayout();
                        scrollView.BackgroundColor = Colors.Transparent;
                        //Content.BackgroundColor = Color.FromArgb("#77DD77");
                        //scrollView.BackgroundColor = Color.FromArgb("#77DD77");
                    }
                    await Task.WhenAll(
                    scrollView.TranslateTo(0, 0, duration),
                    //Content.FadeTo(1, duration),
                    scrollView.FadeTo(1, duration)
                    );


                }
                break;
        }
    }
}

//new VerticalStackLayout
//                    {
//                        GridColumn = 1,
//                        Children =
//                        {
//                            new Label
//                            {
//                                Text = "Spider-Man",
//                                FontAttributes = FontAttributes.Bold,
//                                FontSize = Device.GetNamedSize(NamedSize.Header, typeof(Label)),
//                                GridColumnSpan = 2,
//                                HorizontalOptions = LayoutOptions.Center
//                            },
//                            new BoxView
//                            {
//                                Color = Colors.Black,
//                                HeightRequest = 2,
//                                HorizontalOptions = LayoutOptions.Fill
//                            },
//                            new Label
//                            {
//                                Text = "Action, Adventure",
//                                FontAttributes = FontAttributes.Bold,
//                                FontSize = 12,
//                                GridColumnSpan = 2,
//                                HorizontalOptions = LayoutOptions.Center
//                            },
//                            new BoxView
//                            {
//                                Color = Colors.Black,
//                                HeightRequest = 2,
//                                HorizontalOptions = LayoutOptions.Fill
//                            },
//                            new Border
//                            {
//                                Stroke = Colors.Transparent,
//                                Child = new Grid
//                                {
//                                    RowDefinitions =
//                                    {
//                                        new RowDefinition { Height = GridLength.Auto },
//                                        new RowDefinition { Height = GridLength.Auto },
//                                        new RowDefinition { Height = 10 },
//                                        new RowDefinition { Height = GridLength.Auto },
//                                        new RowDefinition { Height = GridLength.Auto }
//                                    },
//                                    ColumnDefinitions =
//                                    {
//                                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
//                                        new ColumnDefinition { Width = GridLength.Auto }
//                                    },
//                                    Children =
//                                    {
//                                        new Label
//                                        {
//                                            Text = "Directed by",
//                                            GridRow = 0,
//                                            GridColumnSpan = 2
//                                        },
//                                        new Label
//                                        {
//                                            Text = "Sam Raimi",
//                                            GridRow = 1,
//                                            GridColumnSpan = 2,
//                                            FontSize = 12
//                                        },
//                                        new BoxView
//                                        {
//                                            Color = Colors.Black,
//                                            GridRow = 2,
//                                            HeightRequest = 2,
//                                            HorizontalOptions = LayoutOptions.Fill
//                                        },
//                                        new Label
//                                        {
//                                            Text = "Stars",
//                                            GridRow = 3,
//                                            GridColumnSpan = 2
//                                        },
//                                        new Label
//                                        {
//                                            Text = "Tobey Maguire,Tobey Maguire,Tobey Maguire",
//                                            FontSize = 12,
//                                            GridRow = 4,
//                                            GridColumnSpan = 2
//                                        }
//                                    }
//                                }
//                            },
//                            new Grid
//                            {
//                                ColumnDefinitions =
//                                {
//                                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
//                                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
//                                },
//                                Children =
//                                {
//                                    new Button
//                                    {
//                                        Text = "More Info",
//                                        ImageSource = "showlove.png",
//                                        BackgroundColor = Colors.Transparent,
//                                        HorizontalOptions = LayoutOptions.Center,
//                                        ContentLayout = Button.ButtonContentLayout.Top,
//                                        BorderWidth = 0,
//                                        FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
//                                        TextColor = Colors.Black
//                                    },
//                                    new Button
//                                    {
//                                        Text = "Share",
//                                        GridColumn = 1,
//                                        ImageSource = "user.png",
//                                        BackgroundColor = Colors.Transparent,
//                                        HorizontalOptions = LayoutOptions.Center,
//                                        ContentLayout = Button.ButtonContentLayout.Top,
//                                        BorderWidth = 0,
//                                        FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
//                                        TextColor = Colors.Black
//                                    }
//                                }
//                            },
//                            new Label
//                            {
//                                Text = "Released 03 may 2022",
//                                FontAttributes = FontAttributes.Bold,
//                                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
//                                GridColumnSpan = 2,
//                                HorizontalOptions = LayoutOptions.Center
//                            }
//                        }
//                    }