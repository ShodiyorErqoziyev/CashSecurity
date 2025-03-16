using CashSecurity.Components;
using System.Windows;
using System.Windows.Controls;

namespace CashSecurity.Pages;

/// <summary>
/// Interaction logic for TrackPage.xaml
/// </summary>
public partial class TrackPage : Page
{
    public TrackPage()
    {
        InitializeComponent();
    }

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
        for (int i = 0; i < 30; i++)
        {
            TrackComponent trackComponent = new TrackComponent();
            wrpTrack.Children.Add(trackComponent);
        }
    }
}
