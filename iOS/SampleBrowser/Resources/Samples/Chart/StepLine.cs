#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.SfChart.iOS;

#if __UNIFIED__
using Foundation;
using UIKit;
using CoreGraphics;

#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using nint = System.Int32;
using nuint = System.Int32;
using CGSize = System.Drawing.SizeF;
using CGRect = System.Drawing.RectangleF;
#endif
namespace SampleBrowser
{
	public class StepLine : SampleView
	{
		public StepLine ()
		{
			SFChart chart 							= new SFChart ();
			chart.Title.Text 						= new NSString ("CO-2 Intensity Analysis");

			//Primary Axis
			SFNumericalAxis primaryAxis 			= new SFNumericalAxis ();
			chart.PrimaryAxis 						= primaryAxis;
			primaryAxis.Minimum 					= new NSNumber (2005);
			primaryAxis.Maximum 					= new NSNumber (2012);
			primaryAxis.Interval 					= new NSNumber (1);
			primaryAxis.Title.Text 					= new NSString ("Year");
		

			//Secondary Axis
			SFNumericalAxis secondaryAxis 			= new SFNumericalAxis ();
			chart.SecondaryAxis 					= secondaryAxis;
			secondaryAxis.Title.Text				= new NSString ("Intensity(g/KWh)");
			chart.SecondaryAxis.Minimum 			= new NSNumber (390);
			chart.SecondaryAxis.Maximum				= new NSNumber (600);
			chart.SecondaryAxis.Interval 			= new NSNumber (30);
			ChartViewModel dataModel				= new ChartViewModel ();

			SFStepLineSeries series1 = new SFStepLineSeries();
			series1.ItemsSource = dataModel.StepLineData1;
			series1.XBindingPath = "XValue";
			series1.YBindingPath = "YValue";
			series1.EnableTooltip = true;
			series1.DataMarker.ShowMarker = true;
			series1.DataMarker.MarkerColor = UIColor.FromRGB(250, 180, 0);
			series1.Label = "USA";
			series1.LegendIcon = SFChartLegendIcon.Rectangle;
			series1.EnableAnimation = true;
			chart.Series.Add(series1);

			SFStepLineSeries series2 = new SFStepLineSeries();
			series2.ItemsSource = dataModel.StepLineData2;
			series2.XBindingPath = "XValue";
			series2.YBindingPath = "YValue";
			series2.EnableTooltip = true;
			series2.DataMarker.ShowMarker = true;
			series2.DataMarker.MarkerColor = UIColor.FromRGB(63, 56, 43);
			series2.Label = "Korea";
			series2.LegendIcon = SFChartLegendIcon.Rectangle;
			series2.EnableAnimation = true;
			chart.Series.Add(series2);

			SFStepLineSeries series3 = new SFStepLineSeries();
			series3.ItemsSource = dataModel.StepLineData3;
			series3.XBindingPath = "XValue";
			series3.YBindingPath = "YValue";
			series3.EnableTooltip = true;
			series3.DataMarker.MarkerColor = UIColor.FromRGB(193, 109, 91);
			series3.Label = "Japan";
			series3.DataMarker.ShowMarker = true;
			series3.LegendIcon = SFChartLegendIcon.Rectangle;
			series3.EnableAnimation = true;
			chart.Series.Add(series3);

			chart.Legend.Visible 					= true;
			chart.Legend.DockPosition				= SFChartLegendPosition.Bottom;
			chart.AddChartBehavior(new SFChartZoomPanBehavior());
			this.AddSubview(chart);
		}

		public override void LayoutSubviews ()
		{
			foreach (var view in this.Subviews) {
				view.Frame = Bounds;
			}
			base.LayoutSubviews ();
		}
	}
}