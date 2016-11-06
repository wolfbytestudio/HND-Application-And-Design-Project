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
    /// Interaction logic for EditUser.xaml
    /// </summary>
    public partial class EditUser : Page
    {
        /// <summary>
        /// The library object
        /// </summary>
        private Library library;

        /// <summary>
        /// The person contact
        /// </summary>
        private Person contact;

        /// <summary>
        /// Constructor for EditUser
        /// </summary>
        /// <param name="id">the persons id</param>
        public EditUser(int id)
        {
            library = Library.Get;
            this.contact = library.getPersonById(id);

            InitializeComponent();
        }

        /// <summary>
        /// Grid loaded event
        /// </summary>
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            updateFields();
        }

        /// <summary>
        /// A dictonary of the int values to PersonType
        /// 
        /// Stores the int value equivelant to the PersonType
        /// </summary>
        private static readonly Dictionary<int, PersonType> VALUES = new Dictionary<int, PersonType>()
        {
            { 0, PersonType.GUEST },
            { 1, PersonType.RECEPTIONIST },
            { 2, PersonType.ADMINISTRATOR }
        };

        /// <summary>
        /// Updates the persons fields
        /// </summary>
        private void updateFields()
        {
            lblCurrent.Text = "Currently Editing User: " + contact.MemberId;
            txtUsername.Text = contact.Name;
            txtPassword.Text = contact.Password;
            txtStreet.Text = contact._Address.Street;
            txtHouseNumber.Text = contact._Address.HouseNumber;
            txtDebitBalance.Text = contact.AccountBalance + "";
            txtDiscount.Text = contact.Discount * 100 + "";
            txtPostcode.Text = contact._Address.Postcode;
            txtTown.Text = contact._Address.Town;
            txtPhoneNumber.Text = contact.PhoneNumber;
            foreach(var entry in VALUES)
            {
                if(entry.Value == contact.PersonType)
                {
                    cmbType.SelectedIndex = entry.Key;
                }
            }
           
            rdbDeleted.IsChecked = contact.Deleted;
        }

        /// <summary>
        /// Updates the contact
        /// </summary>
        private void updateContact()
        {
            contact.Name = txtUsername.Text;
            txtPassword.Text = contact.Password;
            contact._Address.Street = txtStreet.Text;
            contact._Address.HouseNumber = txtHouseNumber.Text;
            contact.AccountBalance = double.Parse(txtDebitBalance.Text);
            contact.Discount = float.Parse(txtDiscount.Text) / 100;
            contact._Address.Postcode = txtPostcode.Text;
            contact._Address.Town = txtTown.Text;
            contact.PhoneNumber = txtPhoneNumber.Text;
            contact.PersonType = VALUES[cmbType.SelectedIndex];
            contact.Deleted = (bool)rdbDeleted.IsChecked;
        }

        /// <summary>
        /// Cancel button event
        /// </summary>
        private void btnCancel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow.frame.GoBack();
        }

        /// <summary>
        /// Update button event
        /// </summary>
        private void btnUpdate_MouseUp(object sender, MouseButtonEventArgs e)
        {
            updateContact();
            MessageBox.Show("Updated " + contact.Name + " successfully!");
            MainWindow.frame.GoBack();
        }

    }
}
