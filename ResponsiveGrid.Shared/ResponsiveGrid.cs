using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if WINDOWS_WPF
using System.Windows;
using System.Windows.Controls;
#elif WINDOWS_UWP
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#else
#endif


namespace SourceChord.ResponsiveGrid
{
    public class BreakPoints
    {
        public double XS_SM { get; set; }
        public double SM_MD { get; set; }
        public double MD_LG { get; set; }

        public BreakPoints()
        {
        }
    }
    public class ResponsiveGrid : Panel
    {
        public ResponsiveGrid()
        {
            this.MaxDivision = 12;
        }

        #region ResponsiveGrid自体に設定する依存関係プロパティ
        // 各種ブレークポイントの設定用プロパティ
        public int MaxDivision { get; set; }

        public BreakPoints BreakPoints { get; set; }
        #endregion

        #region 各子要素のサイズを決めるための添付プロパティ
        public static int GetXS(DependencyObject obj)
        {
            return (int)obj.GetValue(XSProperty);
        }
        public static void SetXS(DependencyObject obj, int value)
        {
            obj.SetValue(XSProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for XS.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XSProperty =
            DependencyProperty.RegisterAttached("XS",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for XS.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XSProperty =
            DependencyProperty.RegisterAttached("XS", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));

        private static void OnPropChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = d as FrameworkElement;
            var parent = element?.Parent as ResponsiveGrid;
            parent?.InvalidateMeasure();
        }
#else
#endif

        public static int GetSM(DependencyObject obj)
        {
            return (int)obj.GetValue(SMProperty);
        }
        public static void SetSM(DependencyObject obj, int value)
        {
            obj.SetValue(SMProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for SM.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SMProperty =
            DependencyProperty.RegisterAttached("SM",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for SM.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SMProperty =
            DependencyProperty.RegisterAttached("SM", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        public static int GetMD(DependencyObject obj)
        {
            return (int)obj.GetValue(MDProperty);
        }
        public static void SetMD(DependencyObject obj, int value)
        {
            obj.SetValue(MDProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for MD.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MDProperty =
            DependencyProperty.RegisterAttached("MD",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for MD.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MDProperty =
            DependencyProperty.RegisterAttached("MD", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        public static int GetLG(DependencyObject obj)
        {
            return (int)obj.GetValue(LGProperty);
        }
        public static void SetLG(DependencyObject obj, int value)
        {
            obj.SetValue(LGProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for LG.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LGProperty =
            DependencyProperty.RegisterAttached("LG",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for LG.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LGProperty =
            DependencyProperty.RegisterAttached("LG", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        #endregion

        #region Offsetプロパティ
        public static int GetXS_Offset(DependencyObject obj)
        {
            return (int)obj.GetValue(XS_OffsetProperty);
        }
        public static void SetXS_Offset(DependencyObject obj, int value)
        {
            obj.SetValue(XS_OffsetProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for XS_Offset.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XS_OffsetProperty =
            DependencyProperty.RegisterAttached("XS_Offset",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for XS_Offset.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XS_OffsetProperty =
            DependencyProperty.RegisterAttached("XS_Offset", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        public static int GetSM_Offset(DependencyObject obj)
        {
            return (int)obj.GetValue(SM_OffsetProperty);
        }
        public static void SetSM_Offset(DependencyObject obj, int value)
        {
            obj.SetValue(SM_OffsetProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for SM_Offset.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SM_OffsetProperty =
            DependencyProperty.RegisterAttached("SM_Offset",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for SM_Offset.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SM_OffsetProperty =
            DependencyProperty.RegisterAttached("SM_Offset", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        public static int GetMD_Offset(DependencyObject obj)
        {
            return (int)obj.GetValue(MD_OffsetProperty);
        }
        public static void SetMD_Offset(DependencyObject obj, int value)
        {
            obj.SetValue(MD_OffsetProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for MD_Offset.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MD_OffsetProperty =
            DependencyProperty.RegisterAttached("MD_Offset",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for MD_Offset.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MD_OffsetProperty =
            DependencyProperty.RegisterAttached("MD_Offset", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        public static int GetLG_Offset(DependencyObject obj)
        {
            return (int)obj.GetValue(LG_OffsetProperty);
        }
        public static void SetLG_Offset(DependencyObject obj, int value)
        {
            obj.SetValue(LG_OffsetProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for LG_Offset.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LG_OffsetProperty =
            DependencyProperty.RegisterAttached("LG_Offset",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for LG_Offset.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LG_OffsetProperty =
            DependencyProperty.RegisterAttached("LG_Offset", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        #endregion


        #region Pushプロパティ
        public static int GetXS_Push(DependencyObject obj)
        {
            return (int)obj.GetValue(XS_PushProperty);
        }
        public static void SetXS_Push(DependencyObject obj, int value)
        {
            obj.SetValue(XS_PushProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for XS_Push.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XS_PushProperty =
            DependencyProperty.RegisterAttached("XS_Push",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for XS_Push.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XS_PushProperty =
            DependencyProperty.RegisterAttached("XS_Push", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        public static int GetSM_Push(DependencyObject obj)
        {
            return (int)obj.GetValue(SM_PushProperty);
        }
        public static void SetSM_Push(DependencyObject obj, int value)
        {
            obj.SetValue(SM_PushProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for SM_Push.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SM_PushProperty =
            DependencyProperty.RegisterAttached("SM_Push",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for SM_Push.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SM_PushProperty =
            DependencyProperty.RegisterAttached("SM_Push", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        public static int GetMD_Push(DependencyObject obj)
        {
            return (int)obj.GetValue(MD_PushProperty);
        }
        public static void SetMD_Push(DependencyObject obj, int value)
        {
            obj.SetValue(MD_PushProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for MD_Push.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MD_PushProperty =
            DependencyProperty.RegisterAttached("MD_Push",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for MD_Push.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MD_PushProperty =
            DependencyProperty.RegisterAttached("MD_Push", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        public static int GetLG_Push(DependencyObject obj)
        {
            return (int)obj.GetValue(LG_PushProperty);
        }
        public static void SetLG_Push(DependencyObject obj, int value)
        {
            obj.SetValue(LG_PushProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for LG_Push.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LG_PushProperty =
            DependencyProperty.RegisterAttached("LG_Push",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for LG_Push.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LG_PushProperty =
            DependencyProperty.RegisterAttached("LG_Push", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        #endregion


        #region Pullプロパティ
        public static int GetXS_Pull(DependencyObject obj)
        {
            return (int)obj.GetValue(XS_PullProperty);
        }
        public static void SetXS_Pull(DependencyObject obj, int value)
        {
            obj.SetValue(XS_PullProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for XS_Pull.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XS_PullProperty =
            DependencyProperty.RegisterAttached("XS_Pull",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for XS_Pull.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XS_PullProperty =
            DependencyProperty.RegisterAttached("XS_Pull", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        public static int GetSM_Pull(DependencyObject obj)
        {
            return (int)obj.GetValue(SM_PullProperty);
        }
        public static void SetSM_Pull(DependencyObject obj, int value)
        {
            obj.SetValue(SM_PullProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for SM_Pull.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SM_PullProperty =
            DependencyProperty.RegisterAttached("SM_Pull",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for SM_Pull.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SM_PullProperty =
            DependencyProperty.RegisterAttached("SM_Pull", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        public static int GetMD_Pull(DependencyObject obj)
        {
            return (int)obj.GetValue(MD_PullProperty);
        }
        public static void SetMD_Pull(DependencyObject obj, int value)
        {
            obj.SetValue(MD_PullProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for MD_Pull.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MD_PullProperty =
            DependencyProperty.RegisterAttached("MD_Pull",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for MD_Pull.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MD_PullProperty =
            DependencyProperty.RegisterAttached("MD_Pull", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        public static int GetLG_Pull(DependencyObject obj)
        {
            return (int)obj.GetValue(LG_PullProperty);
        }
        public static void SetLG_Pull(DependencyObject obj, int value)
        {
            obj.SetValue(LG_PullProperty, value);
        }
#if WINDOWS_WPF
        // Using a DependencyProperty as the backing store for LG_Pull.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LG_PullProperty =
            DependencyProperty.RegisterAttached("LG_Pull",
                                                typeof(int),
                                                typeof(ResponsiveGrid),
                                                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
#elif WINDOWS_UWP
        // Using a DependencyProperty as the backing store for LG_Pull.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LG_PullProperty =
            DependencyProperty.RegisterAttached("LG_Pull", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0, OnPropChanged));
#else
#endif

        #endregion


        #region 読み取り専用の添付プロパティ
        public static int GetActualColumn(DependencyObject obj)
        {
            return (int)obj.GetValue(ActualColumnProperty);
        }
        protected static void SetActualColumn(DependencyObject obj, int value)
        {
            obj.SetValue(ActualColumnProperty, value);
        }
        // Using a DependencyProperty as the backing store for ActualColumn.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ActualColumnProperty =
            DependencyProperty.RegisterAttached("ActualColumn", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0));

        public static int GetActualRow(DependencyObject obj)
        {
            return (int)obj.GetValue(ActualRowProperty);
        }
        protected static void SetActualRow(DependencyObject obj, int value)
        {
            obj.SetValue(ActualRowProperty, value);
        }
        // Using a DependencyProperty as the backing store for ActualRow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ActualRowProperty =
            DependencyProperty.RegisterAttached("ActualRow", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0));

        #endregion

        protected override Size MeasureOverride(Size availableSize)
        {
            var count = 0;
            var currentRow = 0;

            var availableWidth = double.IsPositiveInfinity(availableSize.Width) ? double.PositiveInfinity : availableSize.Width / this.MaxDivision;
            var children = this.Children.OfType<UIElement>();


            foreach (UIElement child in this.Children)
            {
                if (child != null)
                {
                    var span = this.GetSpan(child, availableSize.Width);
                    var offset = this.GetOffset(child, availableSize.Width);
                    var push = this.GetPush(child, availableSize.Width);
                    var pull = this.GetPull(child, availableSize.Width);
                    if (count + span + offset > this.MaxDivision)
                    {
                        // リセット
                        currentRow++;
                        count = 0;
                    }

                    SetActualColumn(child, count + offset + push - pull);
                    SetActualRow(child, currentRow);

                    count += (span + offset);

                    var size = new Size(availableWidth * span, double.PositiveInfinity);
                    child.Measure(size);
                }
            }

            return base.MeasureOverride(availableSize);
        }

        protected int GetSpan(UIElement element, double width)
        {
            var span = 0;

            var getXS = new Func<UIElement, int>((o) => { var x = GetXS(o); return x != 0 ? x : this.MaxDivision; });
            var getSM = new Func<UIElement, int>((o) => { var x = GetSM(o); return x != 0 ? x : getXS(o); });
            var getMD = new Func<UIElement, int>((o) => { var x = GetMD(o); return x != 0 ? x : getSM(o); });
            var getLG = new Func<UIElement, int>((o) => { var x = GetLG(o); return x != 0 ? x : getMD(o); });

            if (width < this.BreakPoints.XS_SM)
            {
                span = getXS(element);
            }
            else if (width < this.BreakPoints.SM_MD)
            {
                span = getSM(element);
            }
            else if (width < this.BreakPoints.MD_LG)
            {
                span = getMD(element);
            }
            else
            {
                span = getLG(element);
            }

            return Math.Min(Math.Max(0, span), this.MaxDivision); ;
        }

        protected int GetOffset(UIElement element, double width)
        {
            var span = 0;

            var getXS = new Func<UIElement, int>((o) => { var x = GetXS_Offset(o); return x != 0 ? x : 0; });
            var getSM = new Func<UIElement, int>((o) => { var x = GetSM_Offset(o); return x != 0 ? x : getXS(o); });
            var getMD = new Func<UIElement, int>((o) => { var x = GetMD_Offset(o); return x != 0 ? x : getSM(o); });
            var getLG = new Func<UIElement, int>((o) => { var x = GetLG_Offset(o); return x != 0 ? x : getMD(o); });

            if (width < this.BreakPoints.XS_SM)
            {
                span = getXS(element);
            }
            else if (width < this.BreakPoints.SM_MD)
            {
                span = getSM(element);
            }
            else if (width < this.BreakPoints.MD_LG)
            {
                span = getMD(element);
            }
            else
            {
                span = getLG(element);
            }

            return Math.Min(Math.Max(0, span), this.MaxDivision); ;
        }

        protected int GetPush(UIElement element, double width)
        {
            var span = 0;

            var getXS = new Func<UIElement, int>((o) => { var x = GetXS_Push(o); return x != 0 ? x : 0; });
            var getSM = new Func<UIElement, int>((o) => { var x = GetSM_Push(o); return x != 0 ? x : getXS(o); });
            var getMD = new Func<UIElement, int>((o) => { var x = GetMD_Push(o); return x != 0 ? x : getSM(o); });
            var getLG = new Func<UIElement, int>((o) => { var x = GetLG_Push(o); return x != 0 ? x : getMD(o); });

            if (width < this.BreakPoints.XS_SM)
            {
                span = getXS(element);
            }
            else if (width < this.BreakPoints.SM_MD)
            {
                span = getSM(element);
            }
            else if (width < this.BreakPoints.MD_LG)
            {
                span = getMD(element);
            }
            else
            {
                span = getLG(element);
            }

            return Math.Min(Math.Max(0, span), this.MaxDivision); ;
        }

        protected int GetPull(UIElement element, double width)
        {
            var span = 0;

            var getXS = new Func<UIElement, int>((o) => { var x = GetXS_Pull(o); return x != 0 ? x : 0; });
            var getSM = new Func<UIElement, int>((o) => { var x = GetSM_Pull(o); return x != 0 ? x : getXS(o); });
            var getMD = new Func<UIElement, int>((o) => { var x = GetMD_Pull(o); return x != 0 ? x : getSM(o); });
            var getLG = new Func<UIElement, int>((o) => { var x = GetLG_Pull(o); return x != 0 ? x : getMD(o); });

            if (width < this.BreakPoints.XS_SM)
            {
                span = getXS(element);
            }
            else if (width < this.BreakPoints.SM_MD)
            {
                span = getSM(element);
            }
            else if (width < this.BreakPoints.MD_LG)
            {
                span = getMD(element);
            }
            else
            {
                span = getLG(element);
            }

            return Math.Min(Math.Max(0, span), this.MaxDivision); ;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            var columnWidth = finalSize.Width / this.MaxDivision;

            // 行ごとにグルーピングする
            var group = this.Children.OfType<UIElement>()
                                     .GroupBy(x => GetActualRow(x));

            double temp = 0;
            foreach (var rows in group)
            {
                double max = 0;

                var columnHeight = rows.Max(o => o.DesiredSize.Height);
                foreach (var element in rows)
                {
                    var column = GetActualColumn(element);
                    var row = GetActualRow(element);
                    var columnSpan = this.GetSpan(element, finalSize.Width);

                    var rect = new Rect(columnWidth * column, temp, columnWidth * columnSpan, columnHeight);

                    element.Arrange(rect);

                    max = Math.Max(element.DesiredSize.Height, max);
                }

                temp += max;
            }
            return base.ArrangeOverride(finalSize);
        }
    }
}
