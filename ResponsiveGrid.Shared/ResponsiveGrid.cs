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
        // Using a DependencyProperty as the backing store for XS.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XSProperty =
            DependencyProperty.RegisterAttached("XS", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0));

        public static int GetSM(DependencyObject obj)
        {
            return (int)obj.GetValue(SMProperty);
        }
        public static void SetSM(DependencyObject obj, int value)
        {
            obj.SetValue(SMProperty, value);
        }
        // Using a DependencyProperty as the backing store for SM.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SMProperty =
            DependencyProperty.RegisterAttached("SM", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0));

        public static int GetMD(DependencyObject obj)
        {
            return (int)obj.GetValue(MDProperty);
        }
        public static void SetMD(DependencyObject obj, int value)
        {
            obj.SetValue(MDProperty, value);
        }
        // Using a DependencyProperty as the backing store for MD.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MDProperty =
            DependencyProperty.RegisterAttached("MD", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0));

        public static int GetLG(DependencyObject obj)
        {
            return (int)obj.GetValue(LGProperty);
        }
        public static void SetLG(DependencyObject obj, int value)
        {
            obj.SetValue(LGProperty, value);
        }
        // Using a DependencyProperty as the backing store for LG.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LGProperty =
            DependencyProperty.RegisterAttached("LG", typeof(int), typeof(ResponsiveGrid), new PropertyMetadata(0));

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
                    if (count + span > this.MaxDivision)
                    {
                        // リセット
                        currentRow++;
                        count = 0;
                    }

                    SetActualColumn(child, count);
                    SetActualRow(child, currentRow);

                    count += span;

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
