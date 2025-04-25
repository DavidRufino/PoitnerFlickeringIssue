using Microsoft.UI.Xaml;
using PoitnerFlickering.Pages;

namespace PoitnerFlickering;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();

        ExtendsContentIntoTitleBar = true;

        this.MainContent.Content = new MainPage();

        this.Activated -= MainWindow_Activated;
        this.Activated += MainWindow_Activated;
    }

    private void MainGrid_Loaded(object sender, RoutedEventArgs e)
    {
        SetTitleBar(AppTitleBar);
    }

    private void MainWindow_Activated(object sender, WindowActivatedEventArgs args)
    {
        Status.Text = args.WindowActivationState.ToString();
    }
}