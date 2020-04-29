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
    /// Логика взаимодействия для Busket.xaml
    /// </summary>
    public partial class Busket : Page
    {
        bool empty = true;

        private void CheckBusket()
        {
            if (empty)
            {
                BucketEmpty.Visibility = Visibility.Visible;
            }
            else
            {
                BucketEmpty.Visibility = Visibility.Hidden;
            }
        }

        public Busket()
        {
            InitializeComponent();
            CheckBusket();
        }

    }
}
