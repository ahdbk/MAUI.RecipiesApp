namespace MyRecipiesApp.Controls;

public partial class ButtomDrawer: ContentView
{
    uint duration = 100;
    double openY =  200;
    double lastPanY = 0;
    bool isBackdropTapEnabled = true;
    bool isToggled = false;
    double width = DeviceDisplay.MainDisplayInfo.Width;

    public ButtomDrawer()
	{
		InitializeComponent();
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

    protected async void Backdrop_Tapped(object sender, EventArgs args)
	{
        if (isBackdropTapEnabled)
        {
            await CloseDrawer();
        }
    }    
	protected async void PanGestureRecognzer_PanUpdate(object sender, PanUpdatedEventArgs e)
	{
        if (e.StatusType == GestureStatus.Running)
        {
            isBackdropTapEnabled = false;
            lastPanY = e.TotalY;
            Console.WriteLine($"Running: {e.TotalY}");

            Drawer.TranslationY = openY + e.TotalY;

        }
        else if (e.StatusType == GestureStatus.Completed)
        {
            ////Debug.WriteLine($"Completed: {e.TotalY}");
            //if (lastPanY > -110)
            //{
            //   // await OpenDrawer();
            //}
            //else
            //{
            //    //await CloseDrawer();
            //}
            //isBackdropTapEnabled = true;
            Console.WriteLine($"Completed: {e.TotalY}");

        }

    }

    async Task OpenDrawer()
    {
        await Task.WhenAll
        (
            Backdrop.FadeTo(1, length: duration),
            DrawerBody.FadeTo(1, length: duration),
            Drawer.TranslateTo(0, 170, length: duration, easing: Easing.SinIn)
        );
        isToggled = true;
        Backdrop.InputTransparent = false;
    }
    async Task CloseDrawer()
    {
        await Task.WhenAll
   (
       Backdrop.FadeTo(0, length: duration),
       DrawerBody.FadeTo(0, length: duration),
       Drawer.TranslateTo(0, 630, length: duration, easing: Easing.SinIn)
   );
        Backdrop.InputTransparent = true;
        isToggled = false;

    }
}