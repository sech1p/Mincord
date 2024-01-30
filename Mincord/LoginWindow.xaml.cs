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

namespace Mincord
{
    /// <summary>
    /// Logika interakcji dla klasy LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, RoutedEventArgs e)
        {
            var login = new Discord.API.Login();
            var window = new MainWindow();
            try
            {
                await login.LoginAsync(token: tokenTextBox.Password);
                Properties.Settings.Default["Token"] = tokenTextBox.Password;
                Properties.Settings.Default.Save();
                window.Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Failed to login.{Utils.NEWLINE}{Utils.NEWLINE}{exception.Message}", "Mincord", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
        }
    }
}
