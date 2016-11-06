using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FinalPoject.com.people;

namespace FinalPoject.com.hotel.room
{

    /// <summary>
    /// Conference room extends Room
    /// contains methods for conference rooms
    /// 
    /// Author - 30008095 - Zack Davidson
    /// </summary>
    public class ConferenceRoom : Room
    {

        /// <summary>
        /// The maxiumum amount of guests
        /// </summary>
        private static readonly int MAX_GUEST_COUNT = 1000;

        /// <summary>
        /// Conference Room constructor
        /// </summary>
        public ConferenceRoom()
        {
            this.roomId = "The rolling stones";
        }

        /// <summary>
        /// Books the conference room for a specific amount of hours
        /// 
        /// the start date is always today
        /// </summary>
        /// <param name="customerId">The customer id making the booking</param>
        /// <param name="start">The start</param>
        /// <param name="length">the lengh in hours</param>
        /// <param name="guests">the amount of guests</param>
        /// <returns>True if the room has been booked successfully. False if it fails</returns>
        public override bool book(int customerId, int length, int guests)
        {
            if (CustomerId != 0)
            {
                throw new Exception("The Conference Room is already booked!");
            }
            if (guests > MAX_GUEST_COUNT)
            {
                throw new Exception("You can't have more than " + MAX_GUEST_COUNT + " in this room at a time!");
            }
            if (length <= 0)
            {
                throw new Exception("You must book a room for longer than 0 hours!");
            }

            StartDate = DateTime.Now;
            accessible = false;

            this.length = length;
            this.customerId = customerId;

            Person person = Library.Get.getPersonById(customerId);


            double amountToPay = PRICE_TABLE.ConferenceRoomPrice * length;
            double delta = amountToPay * person.Discount;
            double finalPayment = (amountToPay - delta);

            if (person.requestPayment(finalPayment))
            {
                Library.Get.addTransaction(
                    new Transaction(customerId, (amountToPay - delta), startDate, length, roomId));
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

            DateTime endDate = startDate.AddHours(this.length);

            accessible = false;
            this.length += length;

            Person person = Library.Get.getPersonById(customerId);

            double amountToPay = PriceTable.Get.ConferenceRoomPrice;
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
            if (customerId == -1) throw new Exception("This room can't be released as there is no contact!");
            customerId = -1;
            accessible = true;
            return true;
        }

        /// <summary>
        /// Get's a release time for this room
        /// represented like: 30/05/2016 - 13:15
        /// </summary>
        /// <returns></returns>
        public string getReleaseTime()
        {
            if (customerId <= 0)
            {
                return "No customer currently assigned";
            }
            return startDate.AddHours(length).ToShortDateString() +
                " - " + startDate.AddHours(length).ToShortTimeString();
        }
    }
}
