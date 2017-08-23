using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoChart.Models
{
    public static class ChartsData
    {
        //public static readonly object[] BerlinData = { -0.9, 0.6, 3.5, 8.4, 13.5, 17.0, 18.6, 17.9, 14.3, 9.0, 3.9, 1.0 };
        public static readonly string[] Categories = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
       // public static readonly object[] LondonData = { 3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8 };
       // public static readonly object[] NewYorkData = { -0.2, 0.8, 5.7, 11.3, 17.0, 22.0, 24.8, 24.1, 20.1, 14.1, 8.6, 2.5 };
       // public static readonly object[] TokioData = { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };

        

        public static readonly Series TokyoSeries = new Series
        {
            Name = "Tokyo",
            Data = new Data(new[]
            {
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "square" }, Y = 7.0 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "square" }, Y = 6.9 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "square" }, Y = 9.9 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "square" }, Y = 15.5 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "url(../Content/images/sun.png)" }, Y = 18.2 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "square" }, Y = 21.5 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "square" }, Y = 25.2 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "url(../Content/images/sun.png)" }, Y = 26.5 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "square" }, Y = 23.3 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "square" }, Y = 18.3 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "square" }, Y = 13.9 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "square" }, Y = 9.6 }
            })
        };

        public static readonly Series LondonSeries = new Series
        {
            Name = "London",
            Data = new Data(new[]
            {
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "url(../Content/images/snow.png)" }, Y = 3.9 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "diamond" }, Y = 4.2 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "diamond" }, Y = 5.7 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "diamond" }, Y = 8.5 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "diamond" }, Y = 11.9 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "url(../Content/images/snow.png)" }, Y = 15.2 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "diamond" }, Y = 17.0 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "diamond" }, Y = 16.6 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "diamond" }, Y = 14.2 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "diamond" }, Y = 10.3 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "url(../Content/images/snow.png)" }, Y = 6.6 },
                new Point { Marker = new PlotOptionsSeriesMarker { Symbol = "diamond" }, Y = 4.8 }
            })
        };

        
    }
}