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

namespace Prakticheskaya_6
{
    public partial class UserControl1 : UserControl
    {
        private MainWindow mainWindow;
        public string DayInLabel { get; set; }
        public UserControl1(MainWindow mainWindow)
        {
            InitializeComponent();
            DataContext = this;
            this.mainWindow = mainWindow;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ShowCurrentDate(DayInLabel);
        }
    }
}
