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
using System.Windows.Shapes;

namespace My05_WPF_UI
{
    /// <summary>
    /// Interaction logic for LogViewer.xaml
    /// </summary>
    public partial class LogViewer : Window
    {
        public LogViewer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LogViewerModel log = new LogViewerModel();
            var result = log.GetLogFiltered(dateStart.SelectedDate.Value, dateEnd.SelectedDate.Value);
            ListData.ItemsSource = result.ToList();
            countBlock.Content = result.Count().ToString();
        }
    }
}
