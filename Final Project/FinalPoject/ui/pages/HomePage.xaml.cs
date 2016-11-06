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
    /// Interaction logic for HomePage.xaml
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public partial class HomePage : Page
    {

        /// <summary>
        /// The user object - stores the player 
        /// </summary>
        private Person myUser;

        /// <summary>
        /// The library instance
        /// </summary>
        private Library library;

        /// <summary>
        /// Constructor for HomePage
        /// </summary>
        /// <param name="memberId">The member id logging in</param>
        public HomePage(int memberId)
        {
            library = Library.Get;
            myUser = library.getPersonById(memberId);

            InitializeComponent();

            lblWelcomeBack.Text = "Welcome back, " + myUser.Name;

        }

        /// <summary>
        /// Contacts button up only if the user is an administrator
        /// 
        /// Navigates to a new page
        /// </summary>
        /// <param name="sender">The object sender</param>
        /// <param name="e">The Event</param>
        private void btnContacts_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Contacts c = new Contacts();
            MainWindow.frame.Content = c;
        }

        /// <summary>
        /// My Account button event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnMyAccount_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //TODO
        }

        /// <summary>
        /// Make booking button event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnMakeBooking_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BookRoomUser us = new BookRoomUser(myUser.MemberId);
            MainWindow.frame.Content = us;
        }

        /// <summary>
        /// Logout button event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnLogout_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow.frame.GoBack();
        }

        /// <summary>
        /// Price table button event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnPriceTable_MouseUp(object sender, MouseButtonEventArgs e)
        {
            PriceTableChanger ptc = new PriceTableChanger();
            MainWindow.frame.Content = ptc;
        }

        /// <summary>
        /// Add room button event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnAddRoom_MouseUp(object sender, MouseButtonEventArgs e)
        {
            AddRoom ar = new AddRoom();
            MainWindow.frame.Content = ar;
        }

        /// <summary>
        /// Rooms button event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnRooms_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        /// <summary>
        /// Page loaded event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void pge_Loaded(object sender, RoutedEventArgs e)
        {
            if (myUser.PersonType == PersonType.GUEST)
            {
                btnContacts.Visibility = Visibility.Hidden;
                btnRooms.Visibility = Visibility.Hidden;
                btnPriceTable.Visibility = Visibility.Hidden;
                btnAddRoom.Visibility = Visibility.Hidden;
            }
            else if (myUser.PersonType == PersonType.RECEPTIONIST)
            {
                btnAddRoom.Visibility = Visibility.Hidden;
                btnPriceTable.Visibility = Visibility.Hidden;
            }
        }

        /// <summary>
        /// Transactions button event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnTransactions_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Transactions tran = new Transactions();
            MainWindow.frame.Content = tran;
        }
    }
}
