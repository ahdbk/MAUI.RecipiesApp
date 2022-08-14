using MyRecipiesApp.Pages;
using MyRecipiesApp.ViewModel;
using static MyRecipiesApp.Pages.HomePage;

namespace MyRecipiesApp.Controls;

public partial class RecepieBadge : ContentView
{
    public static readonly BindableProperty RecepieProperty =
        BindableProperty.Create(nameof(Recepie), typeof(Recepie), typeof(RecepieBadge), new Recepie());

    public Recepie Recepie
    {
        get => (Recepie)GetValue(RecepieProperty);
        set => SetValue(RecepieProperty, value);
    }
    protected async void OnTapped(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new RecepiePage
        {
            BindingContext = this.BindingContext,

        });
    }

    public RecepieBadge()
    {
        InitializeComponent();
        BindingContext = this;
    }
}