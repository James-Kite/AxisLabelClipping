using LiveCharts;
using LiveCharts.Wpf;
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

namespace AxisLabelClipping
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "A Series",
                    Values = new ChartValues<double> { 123452, 398437, 509147, 209837, 448536 }
                }
            };

            Labels = new string[] { "Bob", "Jim", "Steve", "Angela", "Sarah" };

            LabelFormatter = value => value.ToString("e0") + " y";
        }

        public SeriesCollection Series
        {
            get;
            set;
        }

        public string[] Labels
        {
            get;
            set;
        }

        public Func<double, string> LabelFormatter
        {
            get;
            set;
        }
    }
}
