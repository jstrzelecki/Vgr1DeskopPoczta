using System;
using System.Text.RegularExpressions;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace Vgr1Poczta;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void SprawdzCeneButton(object? sender, RoutedEventArgs e)
    {
        if (Pocztowka.IsChecked == true)
        {
            var uri = new Uri("avares://Vgr1Poczta/Assets/postcard.png");
            using var stream = AssetLoader.Open(uri);
            var bitMap = new Bitmap(stream);
            Obrazek.Source = bitMap;
            Cena.Text = "Cena: 1zł";
        }
        else if (List.IsChecked == true)
        {
            var uri = new Uri("avares://Vgr1Poczta/Assets/letter.png");
            using var stream = AssetLoader.Open(uri);
            var bitMap = new Bitmap(stream);
            Obrazek.Source = bitMap;
            Cena.Text = "Cena: 1.5zł";
        }
        else if (Paczka.IsChecked == true)
        {
            var uri = new Uri("avares://Vgr1Poczta/Assets/package.png");
            using var stream = AssetLoader.Open(uri);
            var bitMap = new Bitmap(stream);
            Obrazek.Source = bitMap;
            Cena.Text = "Cena: 10zł";
        }
    }

    private void SubmitButton(object? sender, RoutedEventArgs e)
    {
        int zipCode;
        bool isNumber = int.TryParse(KodPocztowyTextBox.Text, out zipCode);

        var infoWindow = new PopUpWindow();
        
        if (!isNumber)
        {
           
            infoWindow.InfoLabel.Content = "To nie jest liczba";
            infoWindow.ShowDialog(this);
            return;
        }

        if (zipCode.ToString().Length != 5)
        {
            
            infoWindow.InfoLabel.Content = "Niepoprawna liczba znakow";
            infoWindow.ShowDialog(this);
            return;
        }
        
       
        infoWindow.InfoLabel.Content = "Dane zostały zapisane";
        infoWindow.ShowDialog(this);
    }
}