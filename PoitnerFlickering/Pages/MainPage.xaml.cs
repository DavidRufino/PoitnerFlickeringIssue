using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace PoitnerFlickering.Pages;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void BtnSimple_Click(object sender, RoutedEventArgs e)
    {
        BlankWindow blankPageA = new();
        blankPageA.Activate();
    }

    private void BtnSimple_PointerEntered(object sender, Microsoft.UI.Xaml.Input.PointerRoutedEventArgs e)
    {
        Status.Text = "BtnSimple_Pointer: Entered";
    }

    private void BtnSimple_PointerMoved(object sender, Microsoft.UI.Xaml.Input.PointerRoutedEventArgs e)
    {
        //Status.Text = "BtnSimple_PointerMoved";
    }

    private void BtnSimple_PointerExited(object sender, Microsoft.UI.Xaml.Input.PointerRoutedEventArgs e)
    {
        Status.Text = "BtnSimple_Pointer: Exited";
    }
}