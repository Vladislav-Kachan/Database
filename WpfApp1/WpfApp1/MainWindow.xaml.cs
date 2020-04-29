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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///

    static class GlobalVars
    {
        public static int money=0;
        public static string name="Владислав";
        public static string secondName="Качан";

        public static void CheckMoney(TextBlock Balance)
        {
            Balance.Text = GlobalVars.money.ToString() + "$";
        }
    }

    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {            
            InitializeComponent();
            PageNavigator.Content = new Home(PageNavigator, Balance);
            GlobalVars.CheckMoney(Balance);
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, RoutedEventArgs e)
        {
            DragMove();
        }

        private void ListViewMenu_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch(index)
            {
                case 0: PageNavigator.Content = new Home(PageNavigator, Balance);
                    NextPage.Visibility = Visibility.Hidden;
                    break;
                case 1: PageNavigator.Content = new Phone1();
                    NextPage.Visibility = Visibility.Visible;
                    break;
                case 2: PageNavigator.Content = new Busket();
                    NextPage.Visibility = Visibility.Hidden;
                    break;
                case 3: PageNavigator.Content = new About();
                    NextPage.Visibility = Visibility.Hidden;
                    break;
                default:
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (266 + (60 * index)), 0, 0);
        }


    }
}
