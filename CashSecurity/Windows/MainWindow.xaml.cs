using CashSecurity.Pages;
using System.Windows;

namespace CashSecurity;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Close_Button_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void rb_Home_Click(object sender, RoutedEventArgs e)
    {
        HomePage homePage = new HomePage();
        PageNavigator.Content = homePage;
    }

    private void rb_Track_Click(object sender, RoutedEventArgs e)
    {
        TrackPage trackPage = new TrackPage();
        PageNavigator.Content = new TrackPage();
    }

}