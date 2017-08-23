using DemoChart.Models;
using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoChart.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/
        public ActionResult Index()
        {
            // DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").SetXAxis(new XAxis {  
            //    Categories = new [] {  
            //        "Jan",  
            //        "Feb",  
            //        "Mar",  
            //        "Apr",  
            //        "May",  
            //        "Jun",  
            //        "Jul",  
            //        "Aug",  
            //        "Sep",  
            //        "Oct",  
            //        "Nov",  
            //        "Dec " }   
            //    }).SetSeries(new Series {  
            //    Data = new Data(new object[] {  
            //        29.9,  
            //        71.5,  
            //        106.4,  
            //        129.2,  
            //        144.0,  
            //        176.0,  
            //        135.6,  
            //        148.5,  
            //        216.4,  
            //        .1,  
            //        95.6,  
            //        54.4  
            //    })  
            //});  

            Series value = ChartsData.TokyoSeries;

            Highcharts charts = new Highcharts("chart")
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Spline })
                .SetTitle(new Title { Text = "Monthly Average Temperature" })
                .SetSubtitle(new Subtitle { Text = "Source: WorldClimate.com" })
                .SetXAxis(new XAxis { Categories = ChartsData.Categories })
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "Temperature" },
                    Labels = new YAxisLabels { Formatter = "function() { return this.value +'C°' }" }
                })
                .SetTooltip(new Tooltip
                {
                    Crosshairs = new Crosshairs(true),
                    Shared = true
                })
                .SetPlotOptions(new PlotOptions
                {
                    Spline = new PlotOptionsSpline
                    {
                        Marker = new PlotOptionsSplineMarker
                        {
                            Radius = 4,
                            LineColor = ColorTranslator.FromHtml("#666666"),
                            LineWidth = 1
                        }
                    }
                })
                .SetSeries(new[] { ChartsData.TokyoSeries, ChartsData.LondonSeries });
            return View(charts);
        }
	}
}