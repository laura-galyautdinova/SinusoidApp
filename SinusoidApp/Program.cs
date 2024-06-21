using System;
using OxyPlot;
using OxyPlot.Series;

public class MainViewModel
{
    public PlotModel PlotModel { get; set; }

    public MainViewModel()
    {
        PlotModel = new PlotModel { Title = "Sinusoida" };

        // Tworzenie serii danych (dla sinusoidy)
        var series = new LineSeries();
        for (int i = 0; i < 360; i++)
        {
            double x = i;
            double y = Math.Sin(x * Math.PI / 180); // Użycie funkcji Math.Sin
            series.Points.Add(new DataPoint(x, y));
        }

        // Dodanie serii do modelu wykresu
        PlotModel.Series.Add(series);
    }
}
