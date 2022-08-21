
namespace MyRecipiesApp.Controls;

public partial class ButtomDrawer: ContentView
{
    private const double OPEN_POSITION = 170;
    private const double CLOSE_POSITION = 630;
    private const uint ANNIMATION_DURATION = 100;
    bool isToggled = false;

    public ButtomDrawer()
	{
		InitializeComponent();
        Application.Current.UserAppTheme = AppTheme.Light;

    }

    protected async void OnTapped(object sender, EventArgs args)
    {
        if (!isToggled)
        {
            await OpenDrawer();

        } else
        {
            await CloseDrawer();

        }

    }   

	protected async void PanGestureRecognzer_PanUpdate(object sender, PanUpdatedEventArgs e)
	{
        if (!isToggled)
        {
            await OpenDrawer();

        }
        else
        {
            await CloseDrawer();

        }

    }

    async Task OpenDrawer()
    {
        Drawer.Margin = 0;
        await Task.WhenAll
        (
            DrawerBody.FadeTo(1, length: ANNIMATION_DURATION),
            Drawer.TranslateTo(0, OPEN_POSITION, length: ANNIMATION_DURATION, easing: Easing.SinIn)
        );
        isToggled = true;
    }
    async Task CloseDrawer()
    {
        await Task.WhenAll
   (
       DrawerBody.FadeTo(0, length: ANNIMATION_DURATION),
       Drawer.TranslateTo(0, CLOSE_POSITION, length: ANNIMATION_DURATION, easing: Easing.SinIn)
   );
        isToggled = false;

    }
}