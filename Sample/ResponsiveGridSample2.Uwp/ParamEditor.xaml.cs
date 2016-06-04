using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ResponsiveGridSample2.Uwp
{
    public sealed partial class ParamEditor : UserControl
    {
        public ParamEditor()
        {
            this.InitializeComponent();
        }

        public int[] SpanList { get; set; } = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        public int XS
        {
            get { return (int)GetValue(XSProperty); }
            set { SetValue(XSProperty, value); }
        }
        // Using a DependencyProperty as the backing store for XS.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XSProperty =
            DependencyProperty.Register("XS", typeof(int), typeof(ParamEditor), new PropertyMetadata(0));

        public int SM
        {
            get { return (int)GetValue(SMProperty); }
            set { SetValue(SMProperty, value); }
        }
        // Using a DependencyProperty as the backing store for SM.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SMProperty =
            DependencyProperty.Register("SM", typeof(int), typeof(ParamEditor), new PropertyMetadata(0));

        public int MD
        {
            get { return (int)GetValue(MDProperty); }
            set { SetValue(MDProperty, value); }
        }
        // Using a DependencyProperty as the backing store for MD.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MDProperty =
            DependencyProperty.Register("MD", typeof(int), typeof(ParamEditor), new PropertyMetadata(0));

        public int LG
        {
            get { return (int)GetValue(LGProperty); }
            set { SetValue(LGProperty, value); }
        }
        // Using a DependencyProperty as the backing store for LG.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LGProperty =
            DependencyProperty.Register("LG", typeof(int), typeof(ParamEditor), new PropertyMetadata(0));

    }
}
