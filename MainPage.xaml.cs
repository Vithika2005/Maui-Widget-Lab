using System.Collections.ObjectModel;

namespace WidgetDemoApp;

public partial class MainPage : ContentPage
{
    // Counter tracked in code-behind, as described in the experiment (Step 3,
    // Part 5) — starts at zero and increments every time "Like" is tapped.
    private int likeCount = 0;

    // Bindable collection of skill tags, consumed by the CollectionView's
    // ItemsSource in MainPage.xaml.
    public ObservableCollection<string> Skills { get; set; } =
        new ObservableCollection<string> { "C#", "Xamarin", ".NET MAUI", "Git" };

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this; // makes "Skills" available to the XAML binding
    }

    // Event handler wired to the Like Button's Clicked event (Part 5, Step 3).
    private void OnLikeClicked(object sender, EventArgs e)
    {
        likeCount++;
        LikeButton.Text = $"Like ({likeCount})";
    }

    // Event handler wired to the Message Button's Clicked event (Part 5, Step 4).
    private async void OnMessageClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Message", "Message sent!", "OK");
    }
}
