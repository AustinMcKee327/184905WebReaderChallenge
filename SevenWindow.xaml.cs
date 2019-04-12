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

namespace _184905WebReaderChallenge
{
    /// <summary>
    /// Interaction logic for SevenWindow.xaml
    /// </summary>
    public partial class SevenWindow : Window
    {
        public SevenWindow()
        {
            InitializeComponent();                       
        }
        int month;
        double Total;
        double salesPerMonth;
        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            System.Net.WebClient web = new System.Net.WebClient();
            web.BaseAddress = "https://github.com/IanMcT/April8_2019Assignment";
            System.IO.StreamReader stream = new System.IO.StreamReader
               (web.OpenRead("https://raw.githubusercontent.com/IanMcT/April8_2019Assignment/master/2017.txt"));
            if ((bool)JanuaryRadio.IsChecked)
            {
                month = 1;
            }
            if ((bool)FebuaryRadio.IsChecked)
            {
                month = 2;
            }
            if ((bool)MarchRadio.IsChecked)
            {
                month = 3;
            }
            if ((bool)AprilRadio.IsChecked)
            {
                month = 4;
            }
            if ((bool)MayRadio.IsChecked)
            {
                month = 5;
            }
            if ((bool)JuneRadio.IsChecked)
            {
                month = 6;
            }
            if ((bool)JulyRadio.IsChecked)
            {
                month = 7;
            }
            if ((bool)AugustRadio.IsChecked)
            {
                month = 8;
                
            }
            if ((bool)SeptemberRadio.IsChecked)
            {
                month = 9;
            }
            if ((bool)OctoberRadio.IsChecked)
            {
                month = 10;
            }
            if ((bool)NovemberRadio.IsChecked)
            {
                month = 11;
            }
            if ((bool)DecemberRadio.IsChecked)
            {
                month = 12;
            }
            for (int i = 0; i < month; i++)
            {
                stream.ReadLine();
            }
            lblOutput.Content = "The sales for this month were $" + stream.ReadLine();
            stream.Close();
        }

        private void SummaryButton_Click(object sender, RoutedEventArgs e)
        {
            System.Net.WebClient web = new System.Net.WebClient();
            web.BaseAddress = "https://github.com/IanMcT/April8_2019Assignment";
            System.IO.StreamReader stream = new System.IO.StreamReader
               (web.OpenRead("https://raw.githubusercontent.com/IanMcT/April8_2019Assignment/master/2017.txt"));
            Total = 0;
            salesPerMonth = 0;
            stream.ReadLine();
            while (!stream.EndOfStream)
            {
                double.TryParse(stream.ReadLine(), out salesPerMonth);
                Total += salesPerMonth;
            }
            stream.Close();
            lblOutput.Content = "Total Sales: $" + Total + Environment.NewLine + "Average Sales: $" + Total / 12;
        }
    }
}
