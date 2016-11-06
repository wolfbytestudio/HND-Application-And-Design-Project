using FinalPoject.com.hotel.room;
using FinalPoject.ui.pages;
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

namespace FinalPoject.ui.controls
{
    /// <summary>
    /// Interaction logic for RoomControl.xaml
    /// </summary>
    public partial class RoomControl : UserControl
    {
        /// <summary>
        /// The room object
        /// </summary>
        private BedRoom room;

        /// <summary>
        /// RoomControl constructor
        /// </summary>
        /// <param name="room">the room object</param>
        public RoomControl(BedRoom room)
        {
            InitializeComponent();
            Console.WriteLine(room.RoomId);
            this.room = room;
            if(!room.Accessible)
            {
                this.IsEnabled = false;
                btnBook.BaseColor = "#B1241E";
                int daysLeft = Math.Abs((room.StartDate.AddDays(room.Length) - DateTime.Now).Days);
                if(daysLeft == 0)
                    lblRoomAvailable.Text = "Soon";
                else
                    lblRoomAvailable.Text = daysLeft + " day(s)";
            }
            else
            {
                lblRoomAvailable.Text = "Now";
            }
            lblRoomName.Text = room.RoomId;
            lblRoomType.Text = BedRoom.ROOM_TYPES[room.RoomCount];
        }

        /// <summary>
        /// The book button mouse up
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnBook_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BookRoomAdvanceUser bk = new BookRoomAdvanceUser(BookRoomUser.userId, room);
            MainWindow.frame.Content = bk;
        }
    }
}
