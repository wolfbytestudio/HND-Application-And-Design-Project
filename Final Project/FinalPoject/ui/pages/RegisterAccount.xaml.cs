using FinalPoject.com;
using FinalPoject.com.people;
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
    /// Interaction logic for RegisterAccount.xaml
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public partial class RegisterAccount : Page
    {

        /// <summary>
        /// The Library object
        /// </summary>
        private Library library;

        /// <summary>
        /// RegisterAccount constructor
        /// </summary>
        public RegisterAccount()
        {
            InitializeComponent();
            library = Library.Get;
        }

        /// <summary>
        /// The cancel button mouse up event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnCancel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow.frame.GoBack();
        }

        /// <summary>
        /// The register button mouse up event
        /// 
        /// this validates information
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnRegister_MouseUp(object sender, MouseButtonEventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            string street = txtStreet.Text;
            string town = txtTown.Text;
            string post = txtPostCode.Text;
            string houseNo = txtHouseNumber.Text;
            string phone = txtPhoneNumber.Text;

            string errors = "";

            if(name == "") { errors += "\nYou must enter a valid name!"; }
            if (password.Length <= 4)
            {
                errors += "\nYour password must be more than 4 characters long!";
            }
            if (street == "") { errors += "\nYou must enter a valid street!"; }
            if (town == "") { errors += "\nYou must enter a valid town!"; }
            if (post.Length <= 5 || post.Length >= 9)
            {
                errors += "\nYou must enter a valid postcode! (5 to 8 charcters long)";
            }
            if (houseNo == "") { errors += "\nYou must enter a valid house number"; }
            if(phone == "") { errors += "\nYou must enter a valid phone number"; }

            if(errors != "")//Checks if there is no errors
            {
                MessageBox.Show("Error registering an account due to the following issues: " + errors, "Error adding a member!");
            }
            else
            {
                Person p = new Person(
                    name, password, phone, com.people.PersonType.GUEST)
                    .withAddress(new Address(street, town, post, houseNo))
                    .withBalance(100000)
                    .withDiscount(0.00F);

                library.addPerson(p);

                MessageBox.Show("Registration Complete, Your ID is " + p.MemberId + "\n\nPlease take a not of your id!", "Successfully Added a Member");
                MainWindow.frame.GoBack();
            }
        }

    }
}
