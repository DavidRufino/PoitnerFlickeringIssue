using Microsoft.UI.Xaml;
using PoitnerFlickering.Helpers;
using PoitnerFlickering.Pages;

namespace PoitnerFlickering;

public sealed partial class BlankWindow : Window
{
    private WindowHelper WindowHelper;

    public BlankWindow()
    {
        this.InitializeComponent();

        //this.WindowHelper = new(this);
        ExtendsContentIntoTitleBar = true;

        this.MainContent.Content = new BlankPageA();

        this.Activated -= BlankWindow_Activated;
        this.Activated += BlankWindow_Activated;
    }

    private void MainGrid_Loaded(object sender, RoutedEventArgs e)
    {
        SetTitleBar(AppTitleBar);
    }

    private void BlankWindow_Activated(object sender, WindowActivatedEventArgs args)
    {
        Status.Text = args.WindowActivationState.ToString();
    }
}