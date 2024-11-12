using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using _3ИП1;
using System.Windows.Shapes;
using System.Diagnostics;


namespace _3ИП1

{

    public partial class ReginVeiw : Window
    {


        public ReginVeiw()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            
             
            string login = LoginReg.Text.Trim();
            string password = Pass.Password.Trim();
            string AggPassword = PassAgg.Password.Trim();

                


            if (login.Length > 21 || login.Length < 4)
            {
                MessageBox.Show("Введите логин от 3 до 20 значений!");
            }

            else if (password.Length < 8)
            {
                MessageBox.Show("Введите пароль от 8 значений!");


            }
            else if (password != AggPassword)
            {
                MessageBox.Show("Пароли не совподают!");
            }
            else
            {


                MessageBox.Show(" Вы успешно зарегистрировались! ");
                LoginView loginView = new LoginView();
                loginView.Show();
                this.Close();
            }

        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnReturnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Close();
        }

        private void PassAgg_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
