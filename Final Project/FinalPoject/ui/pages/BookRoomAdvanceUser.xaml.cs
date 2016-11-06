using FinalPoject.com;
using FinalPoject.com.hotel;
using FinalPoject.com.hotel.room;
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
    /// Interaction logic for BookRoomAdvanceUser.xaml
    /// </summary>
    public partial class BookRoomAdvanceUser : Page
    {

        /// <summary>
        /// The library object
        /// </summary>
        private Library library;

        /// <summary>
        /// The price table object
        /// </summary>
        private PriceTable price;

        /// <summary>
        /// The persons id making the booking
        /// </summary>
        private int personId;

        /// <summary>
        /// The room to make a booking for
        /// </summary>
        private BedRoom room;

        /// <summary>
        /// BookRoomAdvanceUser Constructor
        /// </summary>
        /// <param name="personId">The person making the booking</param>
        /// <param name="room">The room hosting the person</param>
        public BookRoomAdvanceUser(int personId, BedRoom room)
        {
            library = Library.Get;
            price = PriceTable.Get;

            this.personId = personId;
            this.room = room;
            InitializeComponent();
        }

        /// <summary>
        /// Cancel button event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnCancel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow.frame.GoBack();
        }

        /// <summary>
        /// Cancel button event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnConfirm_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                int guests = int.Parse(txtGuests.Text);

                room.book(personId, ( 
                    ((DateTime)dateEnd.SelectedDate).AddHours(23).AddMinutes(59).AddSeconds(59) 
                    - DateTime.Now).Days, guests);

                

                room.Services = new List<Services>() { Services.MEALS };

                MessageBox.Show("You successfully booked room " + room.CustomerId);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Updates the prices
        /// </summary>
        public void update()
        {
            try
            {
                double newPrice = price.getPriceFor(room.RoomCount, 
                    DateTime.Now,
                    ((DateTime)dateEnd.SelectedDate).AddHours(23).AddMinutes(59).AddSeconds(59));

                lblOriginal.Text = "Original Price: £" + newPrice;
                lblFinalPrice.Text = "Final Price: £" + Math.Round((newPrice * library.getPersonById(personId).Discount));
            }
            catch
            {
                lblOriginal.Text = "Original Price: error";
                lblFinalPrice.Text = "Final Price: error";

            } 
        }

        /// <summary>
        /// End Calendar event closed
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void dateEnd_CalendarClosed(object sender, RoutedEventArgs e)
        {
            update();
        }

        /// <summary>
        /// Grid loaded event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void grdMain_Loaded(object sender, RoutedEventArgs e)
        {
            lblUsername.Text = "Name: " + library.getPersonById(personId).Name;
            lblID.Text = "ID: " + library.getPersonById(personId).MemberId;
            lblDiscount.Text = "Discount: " + (library.getPersonById(personId).Discount * 100) + "%";

        }

    }
}
