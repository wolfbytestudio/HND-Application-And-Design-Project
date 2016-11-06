using FinalPoject.com;
using FinalPoject.com.hotel.room;
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
    /// Interaction logic for BookRoomUser.xaml
    /// </summary>
    public partial class BookRoomUser : Page
    {

        /// <summary>
        /// The user id
        /// </summary>
        public static int userId;

        /// <summary>
        /// The library objecy
        /// </summary>
        private Library library;

        /// <summary>
        /// BookRoomUser Constuctor
        /// </summary>
        /// <param name="userId">the user id</param>
        public BookRoomUser(int userId)
        {

            BookRoomUser.userId = userId;
            library = Library.Get;

            InitializeComponent();
            populate();
        }

        /// <summary>
        /// Populates the rooms panel with room objects
        /// </summary>
        private void populate()
        {
            foreach(BedRoom b in library._Hotel.Rooms)
            {
                if(b.Accessible)
                {
                    stkRooms.Children.Add(new RoomControl(b));
                }
            }
        }

        /// <summary>
        /// Finds all appropriate rooms based on search filters
        /// </summary>
        private void updateFilteredSearch()
        {
            if (txtRoomName == null) return;

            stkRooms.Children.Clear();


            bool unavailable = (bool)chbUnavaliable.IsChecked;
            int bedRoomType = cmbType.SelectedIndex;
            string name = txtRoomName.Text;

            List<BedRoom> rooms = new List<BedRoom>();

            foreach (BedRoom room in library._Hotel.Rooms)
            {

                //Probably the worst looking code ever
                //http://www.c-sharpcorner.com/uploadfile/dhananjaycoder/finding-multiple-items-in-C-Sharp-list/

                if (room.RoomId.Contains(name))
                {
                    if (unavailable)
                    {
                        if (!room.Accessible)
                        {
                            if (bedRoomType != 0)
                            {
                                if (room.RoomCount == bedRoomType)
                                {
                                    if (!rooms.Contains(room)) 
                                        rooms.Add(room); 
                                        
                                }
                            }
                            else
                            {
                                if (!rooms.Contains(room))
                                    rooms.Add(room);
                            }
                        }
                        else
                        {
                            if (room.Accessible)
                            {
                                if (bedRoomType != 0)
                                {
                                    if (room.RoomCount == bedRoomType)
                                    {
                                        if (!rooms.Contains(room))
                                            rooms.Add(room);
                                    }
                                }
                                else
                                {
                                    if (!rooms.Contains(room))
                                        rooms.Add(room);
                                }
                            }
                        }
                    }
                    else
                    {
                        if(room.Accessible)
                        {
                            if (bedRoomType != 0)
                            {
                                if (room.RoomCount == bedRoomType)
                                {
                                    if (!rooms.Contains(room))
                                        rooms.Add(room);
                                }
                            }
                            else
                            {
                                if (!rooms.Contains(room))
                                    rooms.Add(room);
                            }
                        }
                    }
                }
            }


            foreach (BedRoom b in rooms)
            {
                stkRooms.Children.Add(new RoomControl(b));
            }
        }

        /// <summary>
        /// Checkbox for unavaliable - checked event
        /// </summary>
        private void chbUnavaliable_Checked(object sender, RoutedEventArgs e)
        {
            updateFilteredSearch();
        }

        /// <summary>
        /// Checkbox for unavaliable - unchecked event
        /// </summary>
        private void chbUnavaliable_Unchecked(object sender, RoutedEventArgs e)
        {
            updateFilteredSearch();
        }

        /// <summary>
        /// Type selection text box text change event
        /// </summary>
        private void cmbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            updateFilteredSearch();
        }

        /// <summary>
        /// Txt room name text change event
        /// </summary>
        private void txtRoomName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtRoomName != null)
                updateFilteredSearch();
        }

        /// <summary>
        /// main menu mouse enter event
        /// </summary>
        private void btnMainMenu_MouseEnter(object sender, MouseEventArgs e)
        {
            //currently unfinisehd
        }

        /// <summary>
        /// back butten event
        /// </summary>
        private void btnMainMenu_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow.frame.GoBack();
        }
    }
}
