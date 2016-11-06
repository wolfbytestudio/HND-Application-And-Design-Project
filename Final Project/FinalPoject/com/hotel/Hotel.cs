using FinalPoject.com.hotel.room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoject.com.hotel
{
    /// <summary>
    /// Hotel, contains rooms and a name
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public class Hotel
    {

        /// <summary>
        /// The hotel file for saving and loading
        /// </summary>
        public static readonly string FILE = "hotel.json";

        /// <summary>
        /// The name of the hotel
        /// </summary>
        private string name;

        /// <summary>
        /// The list collection of all rooms
        /// </summary>
        private List<BedRoom> rooms;

        /// <summary>
        /// The conference room object
        /// </summary>
        private ConferenceRoom conferenceRoom;

        /// <summary>
        /// Constructor for Hotel
        /// </summary>
        /// <param name="name">The name of the hotel</param>
        public Hotel(string name)
        {
            this.name = name;
            rooms = new List<BedRoom>();
            conferenceRoom = new ConferenceRoom();
        }

        /// <summary>
        /// Gettter for conferenceRoom
        /// </summary>
        public ConferenceRoom _ConferenceRoom
        {
            get { return conferenceRoom; }
        }

        /// <summary>
        /// Get's the first avaliable
        /// </summary>
        /// <param name="roomCount">The amount of rooms</param>
        /// <returns>The room object</returns>
        public Room getFirstAvailiableRoom(int roomCount)
        {
            parameterCheck(roomCount);

            foreach (BedRoom room in rooms)
            {
                if (roomCount == room.RoomCount && room.Accessible)
                    return room;
            }
            return null;
        }

        /// <summary>
        /// Gets a room by it's id
        /// </summary>
        /// <param name="roomId">The room id</param>
        /// <returns>The room object</returns>
        public Room getRoomById(string roomId)
        {
            foreach (Room room in rooms)
            {
                if (room.RoomId == roomId)
                    return room;
            }
            return null;
        }

        /// <summary>
        /// Checks if the value is between 1 and 4
        /// if false: throw exception
        /// </summary>
        /// <param name="value">the room count</param>
        private void parameterCheck(int value)
        {
            if (value <= 0 || value > 4)
            {
                throw new Exception("Room count must be between 1 and 4");
            }
        }

        /// <summary>
        /// Getter and setter for name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Getter and setter for rooms
        /// </summary>
        public List<BedRoom> Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }


    }
}
