using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Prakticheskaya_6
{
    public partial class MainWindow : Window
    {
        DateTime currentDate;
        public MainWindow()
        {
            InitializeComponent();
            currentDate = DateTime.Now;
            DateNowLabel.Content = currentDate.ToString("MMMM, yyyy");
            GenerateCards();
        }

        private void BeforeDateButton_Click(object sender, RoutedEventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            DateNowLabel.Content = currentDate.ToString("MMMM, yyyy");
        }

        private void AfterDateButton_Click(object sender, RoutedEventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            DateNowLabel.Content = currentDate.ToString("MMMM, yyyy");
        }

        private void GenerateCards()
        {
            for (int i = 0; i < 10; i++) // Измените 10 на нужное вам количество карточек
            {
                UserControl1 card = new UserControl1();
                wrapPanel.Children.Add(card);
            }
        }
    }
}