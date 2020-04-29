using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Card.xaml
    /// </summary>
    public partial class Card : Page
    {
        Frame PageNavigator;
        Random rnd = new Random();
        TextBlock Balance;
        bool firstTime = true; 

        public Card(Frame pageNavigator, TextBlock balance)
        {
            InitializeComponent();
            Balance = balance;
            PageNavigator = pageNavigator;
            WhoAdd.Text = GlobalVars.secondName + " " + GlobalVars.name+":";
            numberTrunsaction.Text += rnd.Next(1000000,9999999).ToString();
        }

        private void Button_AddMoney(object sender, RoutedEventArgs e)
        {
            if (MoneyPay.Text != "")
            {
                GlobalVars.money += Convert.ToInt32(MoneyPay.Text);
                PageNavigator.Content = new Home(PageNavigator, Balance);
                GlobalVars.CheckMoney(Balance);
            }
            else
            {
                MessageBox.Show( "Неврные данные");
            }
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            PageNavigator.Content = new Home(PageNavigator, Balance);
        }
        
        private void Field_ImputNumber(object sender, RoutedEventArgs e)
        {
            if(firstTime)
            {
                numberCard.Text = "";
                firstTime = false;
            }
        }
    }
}
