using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoject.com.hotel
{

    /// <summary>
    /// Abstract room class contains everything to do with a room
    /// This class has 3 abstract methods
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public abstract class Room
    {

        /// <summary>
        /// static PriceTable instance for all room types to share
        /// </summary>
        public static readonly PriceTable PRICE_TABLE = PriceTable.Get;

        /// <summary>
        /// The room ID
        /// </summary>
        protected string roomId;

        /// <summary>
        /// The customer id attatched to the room
        /// </summary>
        protected int customerId;

        /// <summary>
        /// The start date of the room
        /// </summary>
        protected DateTime startDate;

        /// <summary>
        /// The duration the customer will be staying for
        /// </summary>
        protected int length;

        /// <summary>
        /// The amount of guests booked into the room
        /// </summary>
        protected int guests;

        /// <summary>
        /// Boolean to check if the room is accessible or not
        /// </summary>
        protected bool accessible;

        /// <summary>
        /// A list containing the services permitted to the room
        /// </summary>
        protected List<Services> services;

        /// <summary>
        /// Abstract book method books a customer into the room
        /// </summary>
        /// <param name="customerId">The customer making the booking</param>
        /// <param name="length">The length of the stay</param>
        /// <param name="guests">The amount of guests</param>
        public abstract bool book(int customerId, int length, int guests);

        /// <summary>
        /// Abstract extend time method, used to extend the time of stay
        /// for a customer
        /// </summary>
        /// <param name="length">The length extra to stay</param>
        public abstract bool extendTime(int length);

        /// <summary>
        /// Releases the room from a contact
        /// </summary>
        public abstract bool release();

        /// <summary>
        /// Room constructor
        /// </summary>
        /// <param name="roomId">the rooms id</param>
        public Room(string roomId)
        {
            this.roomId = roomId;
            this.accessible = true;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Room() { }

        /// <summary>
        /// Getter + Setter for roomId
        /// </summary>
        public string RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }

        /// <summary>
        /// Getter + Setter for customerId
        /// </summary>
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        /// <summary>
        /// Getter + Setter for startDate
        /// </summary>
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        /// <summary>
        /// Getter + Setter for length
        /// </summary>
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        /// <summary>
        /// Getter + Setter for guests
        /// </summary>
        public int Guests
        {
            get { return guests; }
            set { guests = value; }
        }

        /// <summary>
        /// Getter + Setter for accessible
        /// </summary>
        public bool Accessible
        {
            get { return accessible; }
            set { accessible = value; }
        }

        /// <summary>
        /// Getter + Setter for services
        /// </summary>
        public List<Services> Services
        {
            get { return services; }
            set { services = value; }
        }


    }
}
