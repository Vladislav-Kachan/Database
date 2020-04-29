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
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        bool changeNow = false;
        Frame PageNavigator;
        TextBlock balance;
        public Home(Frame pageNavigator, TextBlock balance1)
        {
            InitializeComponent();
            balance = balance1;
            PageNavigator = pageNavigator;
            name.Text = GlobalVars.name;
            secondName.Text = GlobalVars.secondName;
            Balance.Text = GlobalVars.money.ToString() + "$";
        }

        private void Button_Change(object sender, RoutedEventArgs e)
        {
            if (!changeNow)
            {
                FieldMail.IsEnabled = true;
                FieldPhone.IsEnabled = true;
                FieldName.IsEnabled = true;
                FieldSecondName.IsEnabled = true;
                Change.Content = "Подтвердить";
                changeNow = true;
            }
            else
            {
                FieldMail.IsEnabled = false;
                FieldPhone.IsEnabled = false;
                FieldName.IsEnabled = false;
                FieldSecondName.IsEnabled = false;
                Change.Content = "Подтвердить";
                changeNow = false;
            }
        }
        private void Buuton_AddMoney(object sender, RoutedEventArgs e)
        {
            PageNavigator.Content = new Card(PageNavigator ,balance);
        }
    }
}
