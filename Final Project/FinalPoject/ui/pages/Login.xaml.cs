using FinalPoject.com;
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

namespace FinalPoject.ui.pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public partial class Login : Page
    {

        /// <summary>
        /// The library object
        /// </summary>
        private Library library;


        /// <summary>
        /// Login page constructor
        /// </summary>
        public Login()
        {
            InitializeComponent();
            library = Library.Get;
        }

        /// <summary>
        /// The login button mouse up event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnLogin_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (library.login(txtUsername.Text, txtPassword.Password))
                {
                    HomePage homePage = new HomePage(int.Parse(txtUsername.Text));
                    MainWindow.frame.Content = homePage;
                }
                else
                {
                    lblWrong.Text = "Wrong userID or password";
                    lblWrong.Visibility = Visibility.Visible;
                }
            }
            catch
            {
                lblWrong.Text = "You must enter a UserId and Password";
                lblWrong.Visibility = Visibility.Visible;
            }
            
        }

        /// <summary>
        /// The register button mouse up event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnRegister_MouseUp(object sender, MouseButtonEventArgs e)
        {
            RegisterAccount reg = new RegisterAccount();
            MainWindow.frame.Content = reg;
        }
    }
}
