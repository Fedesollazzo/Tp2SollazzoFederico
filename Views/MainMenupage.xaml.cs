namespace Tp2SollazzoFederico.Views;

public partial class MainMenuPage : ContentPage
{
    public MainMenuPage()
    {
        InitializeComponent();
    }

    private async void OnDesarrolladorClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DesarrolladorPage());
    }

    private async void OnServicioClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ServicioPage());
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}
