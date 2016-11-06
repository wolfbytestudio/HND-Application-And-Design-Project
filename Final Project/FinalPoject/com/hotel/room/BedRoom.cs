using FinalPoject.com.people;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoject.com.hotel.room
{

    /// <summary>
    /// A Bedroom, extends Room and contains a room count
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public class BedRoom : Room
    {

        /// <summary>
        /// Get's a return date in a string format
        /// </summary>
        /// <returns>A string representation of a short date</returns>
        public string getReleaseDate()
        {
            if (customerId <= 0)
            {
                return "No customer currently assigned";
            }

            return startDate.AddDays(length).ToShortDateString();
        }

        /// <summary>
        /// A static dictonary containing string names for the room count
        /// </summary>
        public static readonly Dictionary<int, string> ROOM_TYPES = new Dictionary<int, string>()
        {
            {1, "Single Bedroom" },
            {2, "Double Bedroom" },
            {3, "Treble Bedroom" },
            {4, "Family Bedroom" }
        };


        /// <summary>
        /// The amount of rooms in a bedroom
        /// </summary>
        private readonly int roomCount;

        /// <summary>
        /// BedRoom constructor
        /// </summary>
        /// <param name="roomCount">the amount of rooms</param>
        public BedRoom(int roomCount)
            : base((roomCount + "-" + (Library.Get.getRoomCount(roomCount) + 1)))
        {
            this.roomCount = roomCount;
        }

        /// <summary>
        /// Getter + Setter for roomCount
        /// </summary>
        public int RoomCount
        {
            get { return roomCount; }
        }

        /// <summary>
        /// Books a room for a specific lenght and for a certain amount of guests
        /// 
        /// the start date is always today
        /// </summary>
        /// <param name="customerId">The customer id making the booking</param>
        /// <param name="start">The start</param>
        /// <param name="length"></param>
        /// <param name="guests"></param>
        /// <returns>True if the room has been booked successfully. False if it fails</returns>
        public override bool book(int customerId, int length, int guests)
        {
            if (CustomerId != 0)
            {
                throw new Exception("This room is already booked!");
            }
            if (length <= 0)
            {
                throw new Exception("You must book a room for longer than 0 days!");
            }

            this.length = length;
            startDate = DateTime.Now;

            DateTime endDate = startDate.AddDays(length);

            Person person = Library.Get.getPersonById(customerId);
            

            double amountToPay = 0;

            try
            {
                amountToPay = PRICE_TABLE.getPriceFor(
                            roomCount, startDate, endDate);
            }

            catch (Exception ex) { throw new Exception(ex.Message); }

            double delta = amountToPay * person.Discount;

            if (person.requestPayment(amountToPay - delta))
            {
                Library.Get.addTransaction(
                    new Transaction(customerId, Math.Round((amountToPay - delta), 3), startDate, length, roomId));

                this.guests = guests;
                this.accessible = false;
                this.customerId = customerId;
                return true;
            }
            else
            {
                throw new Exception("This member doesn't have enough money");
            }
        }

        /// <summary>
        /// Extends the room time by the length given
        /// </summary>
        /// <param name="length">the length to extend the room by</param>
        /// <returns>true if the room time has been extended</returns>
        public override bool extendTime(int length)
        {
            if (customerId == 0) throw new Exception("Error releasing room: Currently nobody has booked this room.");
            if (length <= 0) throw new Exception("You can not extend for minus days");

            DateTime endDate = startDate.AddDays(this.length);

            accessible = false;
            this.length += length;

            Person person = Library.Get.getPersonById(customerId);

            double amountToPay = PRICE_TABLE.getPriceFor(roomCount, endDate, endDate.AddDays(length));
            double delta = amountToPay * person.Discount;

            if (person.requestPayment(amountToPay - delta))
            {
                Library.Get.addTransaction(
                    new Transaction(customerId, (amountToPay - delta), endDate, length, roomId));
            }
            else
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Releases the room
        /// </summary>
        /// <returns>true if the room has been released, false if not</returns>
        public override bool release()
        {
            if (customerId == 0)
            {
                throw new Exception("This room can't be released as there is no contact!");
            }
            customerId = 0;
            accessible = true;
            return true;
        }


    }
}
