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

    }

    private void rb_Track_Click(object sender, RoutedEventArgs e)
    {

    }

}