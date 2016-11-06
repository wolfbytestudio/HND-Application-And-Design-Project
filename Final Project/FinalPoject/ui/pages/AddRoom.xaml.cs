using FinalPoject.com;
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
    /// Interaction logic for AddRoom.xaml
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public partial class AddRoom : Page
    {

        /// <summary>
        /// The library object
        /// </summary>
        private Library library;

        /// <summary>
        /// AddRoom Constructor
        /// </summary>
        public AddRoom()
        {
            InitializeComponent();

            library = Library.Get;
            updateStats();
        }

        /// <summary>
        /// Updates the statistics for the room counts
        /// </summary>
        private void updateStats()
        {
            lblSingleBedrooms.Text = "Single Bedrooms: " + library.getRoomCount(1);
            lblDoubleBedrooms.Text = "Double Bedrooms: " + library.getRoomCount(2);
            lblTrebleBedrooms.Text = "Treble Bedrooms: " + library.getRoomCount(3);
            lblFamilyBedrooms.Text = "Family Bedrooms: " + library.getRoomCount(4);
        }

        /// <summary>
        /// GoBack button mouse up event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnGoBack_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow.frame.GoBack();
        }

        /// <summary>
        /// The AddRoom button mouse up event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnAddRoom_MouseUp(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < int.Parse(txtRoom.Text); i++ )
            {
                BedRoom bed = new BedRoom((cmbBedroom.SelectedIndex + 1));
                if (library.addRoom(bed))
                {
                    lblMessage.Text = "Added room " + bed.RoomId + "successfully!";
                    lblMessage.Visibility = System.Windows.Visibility.Visible;
                }
                else
                {
                    lblMessage.Text = "Error adding room!";
                    lblMessage.Visibility = System.Windows.Visibility.Visible;
                }
            }
            updateStats();
        }


    }
}
