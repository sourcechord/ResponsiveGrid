using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ResponsiveGridSample3.Wpf
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddGridItem(object sender, RoutedEventArgs e)
        {
            rgrid.Children.Add(new Border());
        }

        private void RemoveGridItem(object sender, RoutedEventArgs e)
        {
            var count = rgrid.Children.Count;
            if (count > 0)
            {
                rgrid.Children.RemoveAt(count-1);
            }
        }
    }
}
