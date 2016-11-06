using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoject.com.people
{

    /// <summary>
    /// Address class contains variables to define an address
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public class Address
    {

        /// <summary>
        /// The street
        /// </summary>
        private string street;

        /// <summary>
        /// The house number
        /// </summary>
        private string houseNumber;

        /// <summary>
        /// The town
        /// </summary>
        private string town;

        /// <summary>
        /// The postcode
        /// </summary>
        private string postcode;

        /// <summary>
        /// Getter + Setter for street
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        /// <summary>
        /// Getter + Setter for town
        /// </summary>
        public string Town
        {
            get { return town; } 
            set { town = value; }
        }

        /// <summary>
        /// Getter + Setter for postcode
        /// </summary>
        public string Postcode
        {
            get {  return postcode; } 
            set { postcode = value; }
        }

        /// <summary>
        /// Getter + Setter for houseNumber
        /// </summary>
        public string HouseNumber
        {
            get { return houseNumber; }
            set { houseNumber = value; }
        }

        /// <summary>
        /// Address constructor
        /// </summary>
        /// <param name="street">the street</param>
        /// <param name="town">the town</param>
        /// <param name="postcode">the postcode</param>
        /// <param name="houseNumber">the house number</param>
        public Address(string street, string town, string postcode, string houseNumber)
        {
            this.street = street;
            this.town = town;
            this.postcode = postcode;
            this.houseNumber = houseNumber;
        }

        /// <summary>
        /// Sets an address
        /// </summary>
        /// <param name="street"></param>
        /// <param name="town"></param>
        /// <param name="postcode"></param>
        /// <param name="houseNumber"></param>
        public void setAddress(string street, string town, string postcode, string houseNumber)
        {
            this.street = street;
            this.town = town;
            this.postcode = postcode;
            this.houseNumber = houseNumber;
        }

        /// <summary>
        /// Overridden ToString method formats a string to: houseNumber street town postcode
        /// for example: 1 andrew street glasgow g5
        /// </summary>
        /// <returns>the formatted string</returns>
        public override string ToString()
        {
            return houseNumber + " " + street + " " + town + " " + postcode;
        }


    }
}
