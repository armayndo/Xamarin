#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SampleBrowser;
using Xamarin.Forms.Internals;

namespace SampleBrowser.SfListView
{
    [Preserve(AllMembers = true)]
    public partial class IncomingTextTemplate : ViewCell
    {
        #region IncomingMessageTemplate
        public IncomingTextTemplate()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.UWP)
                this.gridLayout.ColumnSpacing = Device.Idiom == TargetIdiom.Desktop || Device.Idiom == TargetIdiom.Tablet ? -23 : -23;
            if (Device.RuntimePlatform == Device.Android)
                this.frame.BackgroundColor = Device.Idiom == TargetIdiom.Phone || Device.Idiom == TargetIdiom.Tablet ? Color.FromRgb(192, 238, 252) : Color.FromRgb(192, 238, 252);
            if (Device.RuntimePlatform == Device.iOS)
                this.frame.BackgroundColor = Device.Idiom == TargetIdiom.Phone || Device.Idiom == TargetIdiom.Tablet ? Color.FromRgb(192, 238, 252) : Color.FromRgb(192, 238, 252);
        }

        #endregion
    }
}