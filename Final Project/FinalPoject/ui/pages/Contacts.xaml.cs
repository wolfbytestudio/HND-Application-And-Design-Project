using FinalPoject.com;
using FinalPoject.com.people;
using FinalPoject.ui.controls;
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
    /// Interaction logic for Contacts.xaml
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public partial class Contacts : Page
    {

        /// <summary>
        /// The Library Object
        /// </summary>
        private Library library;

        /// <summary>
        /// Contacts constructor
        /// </summary>
        public Contacts()
        {
            InitializeComponent();

            library = Library.Get;

            foreach (Person p in library.People)
            {
                stkContacts.Children.Add(new SmallContactControl(p, this));
            }
        }

        /// <summary>
        /// The person selected
        /// </summary>
        private int personSelected;

        /// <summary>
        /// Displays information for a selected person
        /// </summary>
        /// <param name="p">the person to display the information</param>
        public void select(Person p)
        {
            personSelected = p.MemberId;
            grdContact.Visibility = Visibility.Visible;
            lblContactId.Content = "Contact ID: " + p.MemberId;
            lblContactName.Content = "Contact Name: " + p.Name;
            lblPassword.Content = "Contact Password: " + p.Password;
            lblStreet.Content = "Street: "+p._Address.Street;
            lblCity.Content = "Town: " + p._Address.Town;
            lblPostcode.Content = "Postcode: " + p._Address.Postcode;
            lblHouseNo.Content = "House: " + p._Address.HouseNumber;
            lblDiscount.Content = "Discount: " + (p.Discount * 100) + "%";
            lblPhone.Content = "Phone Number: " + p.PhoneNumber;
            lblDebit.Content = "Debit Amount: £" + p.AccountBalance;
            lblPersonType.Content = "Person Type: " + p.PersonType.ToString();
            lblDeleted.Content = "Deleted: " + p.Deleted.ToString();
        }

        /// <summary>
        /// The main menu button up event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnMainMenu_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow.frame.GoBack();
        }

        /// <summary>
        /// The search box text change
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtSearch.Text == "")
            {
                stkContacts.Children.Clear();
                foreach (Person p in library.People)
                {
                    stkContacts.Children.Add(new SmallContactControl(p, this));
                }
                return;
            }

            search(txtSearch.Text);
        }

        /// <summary>
        /// Search function to search all the users, either use the id or the users name
        /// </summary>
        /// <param name="input">the input string</param>
        public void search(string input)
        {
            stkContacts.Children.Clear();
            try
            {
                int id = int.Parse(input);
                foreach (Person p in library.People)
                {
                    string memberId = p.MemberId + "";
                    if (memberId.Contains(input + ""))
                        stkContacts.Children.Add(new SmallContactControl(p, this));
                }
            }
            catch
            {
                Console.WriteLine("name search");
                foreach (Person p in library.People)
                {
                    Console.WriteLine("checking for: " + p.Name.ToLower());
                    Console.WriteLine("contains: " + input.ToLower());
                    if (p.Name.ToLower().Contains(input.ToLower()))
                        stkContacts.Children.Add(new SmallContactControl(p, this));
                }
            }
        }

        /// <summary>
        /// The clear button mouse up event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnClear_MouseUp(object sender, MouseButtonEventArgs e)
        {
            txtSearch.Text = "";
        }

        /// <summary>
        /// Edit contact mouse up event
        /// </summary>
        private void btnEditContact_MouseUp(object sender, MouseButtonEventArgs e)
        {
            EditUser edit = new EditUser(personSelected);
            MainWindow.frame.Content = edit;
        }

        /// <summary>
        /// Grid loaded event
        /// </summary>
        private void grdContact_Loaded(object sender, RoutedEventArgs e)
        {
            if(personSelected != 0)
            {
                stkContacts.Children.Clear();
                foreach (Person p in library.People)
                {
                    stkContacts.Children.Add(new SmallContactControl(p, this));
                    select(library.getPersonById(personSelected));
                }

            }
        }
    }
}
