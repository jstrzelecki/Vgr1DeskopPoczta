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
        Regex regex = new Regex("[0-9]*");
        int cityCodeNumber = 0;
        if (KodPocztowyTextBox.Text.Length != 5)
        {
            Console.WriteLine("nie poprawna ilosc znakow");
        }
        else if ()
        {
            Console.WriteLine("poprawne znaki");
        }
        else if (KodPocztowyTextBox.Text.Length == 5)
        {
            Console.WriteLine("poprawna ilosc znakow");
        }
        
        {
            
        }
    }
}