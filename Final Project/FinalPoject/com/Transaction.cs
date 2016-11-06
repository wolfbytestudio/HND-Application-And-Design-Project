using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoject.com
{

    /// <summary>
    /// Transaction class contains basic transaction details
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public class Transaction
    {

        /// <summary>
        /// The transaction file for saving to and loading from
        /// </summary>
        public static readonly string FILE = "transactions.json";

        /// <summary>
        /// The id of the transaction
        /// </summary>
        private int transactionId;

        /// <summary>
        /// The member id who made the purchase
        /// </summary>
        private int memberId;

        /// <summary>
        /// The amount that was transactioned
        /// </summary>
        private double amount;

        /// <summary>
        /// The date of the transaction
        /// </summary>
        private DateTime date;

        /// <summary>
        /// The length of stay
        /// </summary>
        private int length;

        /// <summary>
        /// The room name
        /// </summary>
        private string roomName;

        /// <summary>
        /// Transaction Constructor
        /// </summary>
        /// <param name="memberId">The member id</param>
        /// <param name="amount">The amount</param>
        /// <param name="date">The date</param>
        /// <param name="length">The length</param>
        /// <param name="roomName">The room</param>
        public Transaction(int memberId, double amount, DateTime date, int length, string roomName)
        {
            transactionId = Library.Get.Transactions.Count + 1;
            this.memberId = memberId;
            this.date = date;
            this.amount = amount;
            this.length = length;
            this.roomName = roomName;
        }

        /// <summary>
        /// Getter + Setter for transactionId
        /// </summary>
        public int TransactionId
        {
            get { return transactionId; }
            set { transactionId = value; }
        }

        /// <summary>
        /// Getter + Setter for memberId
        /// </summary>
        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }

        /// <summary>
        /// Getter + Setter for amount
        /// </summary>
        public double Amount
        {
            get { return amount; } 
            set { amount = value; }
        }

        /// <summary>
        /// Getter + Setter for date
        /// </summary>
        public DateTime Date
        {
            get { return date; } 
            set { date = value; }
        }

        /// <summary>
        /// Getter + Setter for length
        /// </summary>
        public int Length
        {
            get { return length; } 
            set  { length = value; }
        }

        /// <summary>
        /// Getter + Setter for roomName
        /// </summary>
        public string RoomName
        {
            get { return roomName; } 
            set { roomName = value; }
        }
    }
}
