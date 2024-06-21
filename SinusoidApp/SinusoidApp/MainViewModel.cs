using OxyPlot;
using OxyPlot.Series;
using System;

namespace SinusoidApp
{
    public class MainViewModel
    {
        public PlotModel PlotModel { get; set; }

        public MainViewModel()
        {
            PlotModel = new PlotModel { Title = "Sinusoida" };

            var series = new LineSeries();
            for (int i = 0; i < 360; i++)
            {
                double x = i;
                double y = Math.Sin(x * Math.PI / 180);
                series.Points.Add(new DataPoint(x, y));
            }

            PlotModel.Series.Add(series);
        }
    }
}
