using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TemperatureConverterApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void Celsius_TextChanged(object? sender, RoutedEventArgs e)
    {
        if (string.IsNullOrEmpty(Celsius.Text) || Celsius.Text == "-")
        {
            Fahrenheit.Text = "";
        }
        else if (double.TryParse(Celsius.Text, out double celsius))
        {
            double fahrenheit = celsius * (9d / 5d) + 32;
            Fahrenheit.Text = fahrenheit.ToString("0.0");
        }
        else
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";
        }
    }
}