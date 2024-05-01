using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Prakticheskaya_6
{
    public partial class MainWindow : Window
    {
        ModelDannix modelDannix = new ModelDannix();
        List<ModelDannix> modelDannixes = new List<ModelDannix>();
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
            GenerateCards();
        }

        private void AfterDateButton_Click(object sender, RoutedEventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            DateNowLabel.Content = currentDate.ToString("MMMM, yyyy");
            GenerateCards();
        }

        private void GenerateCards()
        {
            wrapPanel.Children.Clear();
            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            for (int i = 1; i <= daysInMonth; i++)
            {
                UserControl1 card = new UserControl1(this);
                card.DayInLabel = i.ToString();
                wrapPanel.Children.Add(card);
            }
        }
        
        public void ShowCurrentDate(string date)
        {
            int day = int.Parse(date);
            DateTime fullDate = new DateTime(currentDate.Year, currentDate.Month, day);
            MessageBox.Show(fullDate.ToString("d"));
            modelDannix.dateTime = fullDate;
            modelDannix.checkbox_1 = true;
            modelDannix.checkbox_2 = true;
            modelDannix.checkbox_3 = true;
            modelDannix.checkbox_4 = true;
            modelDannix.checkbox_5 = true;
            modelDannix.checkbox_6 = true;
            modelDannix.checkbox_7 = true;
            modelDannix.checkbox_8 = true;
            modelDannixes.Add(modelDannix);
            JSONchik.mySerialize(modelDannixes);
        }
    }
}