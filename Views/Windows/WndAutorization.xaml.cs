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

namespace RestaurantApp.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class WndAutorization : Window
    {
        public WndAutorization()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Извините, функция в разработке в данный момент!");
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Извините, функция в разработке в данный момент!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Text == "admin" && (psbPassword.Password == "admin" || txtPassword.Text == "admin"))
            {
                Views.Windows.WndHome wndHome = new Views.Windows.WndHome();
                this.Close();
                MessageBox.Show($"Здравствуйте, {txtLogin.Text}! \nПеред Вами открывается главное окно приложения. \n" +
                    $"Заказывайте с удовольствием, с нами вкусно и легко!");
                wndHome.Show();

            }
            else if (txtLogin.Text == "admin")
            {
                if (psbPassword.Password != "admin" || txtPassword.Text != "admin")
                {
                    MessageBox.Show("Неверно заполнено поле пароля!");
                }
                else if (psbPassword.Password == "" || txtPassword.Text == ""
                                    || psbPassword.Password is null || txtPassword.Text is null)
                {
                    MessageBox.Show("Не заполнено поле пароля!");
                }

            }
            else 
            {
                MessageBox.Show("Неверно заполнено поле логина!");
            }
        }

        private void chkShowPass_Checked(object sender, RoutedEventArgs e)
        {
            if (chkShowPass.IsChecked == true)
            {
                txtPassword.Visibility = Visibility.Visible;
                psbPassword.Visibility = Visibility.Hidden;
                txtPassword.Text = psbPassword.Password;
            }
            else
            {
                psbPassword.Visibility = Visibility.Visible;
                txtPassword.Visibility = Visibility.Hidden;
                psbPassword.Password = txtPassword.Text;
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
