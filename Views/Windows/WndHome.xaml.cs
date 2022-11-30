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

namespace RestaurantApp.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для WndHome.xaml
    /// </summary>
    public partial class WndHome : Window
    {
        public WndHome()
        {
            InitializeComponent();
        }

        private void LogoContainer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Views.Windows.WndAutorization wndAutorization = new WndAutorization();
            this.Close();
            MessageBox.Show("Возвращайтесь скорее!");
            wndAutorization.Show();   
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Извините, функция в разработке в данный момент!");
        }

        private void btnAddPosition_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Извините, функция в разработке в данный момент!");
        }

        private void btnRemovePosition_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Извините, функция в разработке в данный момент!");
        }

        private void rdbMenu_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Извините, функция в разработке в данный момент!");
        }

        private void rdbContacts_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Извините, функция в разработке в данный момент!");
        }

        private void btnMinimizedHome_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnExitHome_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
