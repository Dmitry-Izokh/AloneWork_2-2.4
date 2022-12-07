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

namespace AloneWork_2_2._4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double sumEuro = Convert.ToDouble(sumE.Text);
            double resEuro = rateEuro * sumEuro;
            resSumE.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateUan = Convert.ToDouble(rateU.Text);
            double sumUan = Convert.ToDouble(sumU.Text);
            double resUan = rateUan * sumUan;
            resSumU.Text = resUan.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateFunt = Convert.ToDouble(rateF.Text);
            double sumFunt = Convert.ToDouble(sumF.Text);
            double resFunt = rateFunt * sumFunt;
            resSumF.Text = resFunt.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double inch = Convert.ToDouble(amountInch.Text);
            double inchToMetr = inch* 0.0254;
            resInch.Text = inchToMetr.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double foot = Convert.ToDouble(amountFoot.Text);
            double footToMetr = foot * 0.3048;
            resFoot.Text = footToMetr.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double mile = Convert.ToDouble(amountMile.Text);
            double mileToMetr = mile * 1609.34;
            resMile.Text = mileToMetr.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double verst = Convert.ToDouble(amountVerst.Text);
            double verstToMetr = verst * 1066.8;
            resVerst.Text = verstToMetr.ToString();
        }
    }
}
