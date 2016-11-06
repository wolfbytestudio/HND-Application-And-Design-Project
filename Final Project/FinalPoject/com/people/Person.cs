using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoject.com.people
{
    /// <summary>
    /// The person class contains variables to define a person
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public class Person
    {

        /// <summary>
        /// The Person file for saving to and loading from
        /// </summary>
        public static readonly string FILE = "people.json";

        /// <summary>
        /// The member id
        /// </summary>
        private int memberId;

        /// <summary>
        /// The persons name
        /// </summary>
        private string name;

        /// <summary>
        /// The persons password
        /// </summary>
        private string password;

        /// <summary>
        /// The persons address object
        /// </summary>
        private Address address;

        /// <summary>
        /// The persons discount
        /// </summary>
        private float discount;

        /// <summary>
        /// The persons phone number
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// The persons account balance
        /// </summary>
        private double accountBalance;

        /// <summary>
        /// The person type
        /// </summary>
        private PersonType personType;

        /// <summary>
        /// Checks if a person is deleted or not
        /// </summary>
        private bool deleted;

        /// <summary>
        /// Getter + Setter for memberId
        /// </summary>
        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }

        /// <summary>
        /// Getter + Setter for password
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// Getter + Setter for name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Getter + Setter for address
        /// </summary>
        public Address _Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Getter + Setter for discount
        /// </summary>
        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        /// <summary>
        /// Getter + Setter for phoneNumber
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// Getter + Setter for accountBalance
        /// </summary>
        public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        /// <summary>
        /// Getter + Setter for personType
        /// </summary>
        public PersonType PersonType
        {
            get { return personType; }
            set { personType = value; }
        }

        /// <summary>
        /// Getter + Setter for deleted
        /// </summary>
        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        /// <summary>
        /// Constructor for Person
        /// </summary>
        /// <param name="name">The persons name</param>
        /// <param name="password">The persons password</param>
        /// <param name="phoneNumber">The persons phone number</param>
        /// <param name="personType">The persons type</param>
        public Person(string name, string password, string phoneNumber, PersonType personType)
        {
            this.memberId = (Library.Get.People.Count + 1);
            this.password = password;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.personType = personType;
        }

        /// <summary>
        /// Adds a person with an address
        /// </summary>
        /// <param name="address">the address</param>
        /// <returns>the person including address</returns>
        public Person withAddress(Address address)
        {
            this._Address = address;
            return this;
        }

        /// <summary>
        /// Adds a person with a discount
        /// </summary>
        /// <param name="discount">the discount</param>
        /// <returns>the person including the discount</returns>
        public Person withDiscount(float discount)
        {
            this.Discount = discount;
            return this;
        }

        /// <summary>
        /// Adds a person with a balance
        /// </summary>
        /// <param name="balance">the balance</param>
        /// <returns>the person including the balance</returns>
        public Person withBalance(double balance)
        {
            this.AccountBalance = balance;
            return this;
        }

        /// <summary>
        /// Reuests a payment and takes the amount 
        /// from the persons balance
        /// </summary>
        /// <param name="amount">The amount being taken from the persons balance</param>
        /// <returns>true if the payment is sucessful, false if not</returns>
        public bool requestPayment(double amount)
        {
            if (accountBalance - amount < 0)
            {
                return false;
            }

            accountBalance -= amount;
            return true;
        }

        /// <summary>
        /// Overriden tostring method
        /// </summary>
        /// <returns>a string representation of the person</returns>
        public override string ToString()
        {
            return "Name: " + name
                + "\nMember ID: " + memberId
                + "\nPassword: " + password
                + "\nAddress: " + address
                + "\nDiscount: " + discount + "%"
                + "\nAccount Balance: " + AccountBalance
                + "\nPhone Number: " + phoneNumber
                + "\nPersonType: " + personType.ToString()
                + "\nDeleted? " + (deleted == true ? "Yes" : "No");
        }

    }
}
