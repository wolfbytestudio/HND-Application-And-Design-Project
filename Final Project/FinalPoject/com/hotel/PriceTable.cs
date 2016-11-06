using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows;

namespace FinalPoject.com.hotel
{

    /// <summary>
    /// Contains all the prices for the high, mid and low season.
    /// Also contians the conference room price
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public class PriceTable
    {

        /// <summary>
        /// Static instance of the price table
        /// </summary>
        private static PriceTable priceTable = new PriceTable();

        /// <summary>
        /// Static PriceTable getter
        /// </summary>
        public static PriceTable Get
        {
            get { return priceTable; }
            private set { priceTable = value; }
        }

        /// <summary>
        /// The file name for saving to and loading from
        /// </summary>
        private static readonly string FILE = "room_prices.json";

        /// <summary>
        /// Conference room price
        /// </summary>
        private static readonly string CONFERENCE_FILE = "conference_price.json";

        /// <summary>
        /// A dictonary object to hold all prices
        /// </summary>
        private Dictionary<int, TimePrice> prices;

        /// <summary>
        /// The conference room price
        /// </summary>
        private double conferenceRoomPrice;

        /// <summary>
        /// Getter + Setter for conferenceRoom
        /// </summary>
        public double ConferenceRoomPrice
        {
            get { return conferenceRoomPrice; }
            set { conferenceRoomPrice = value; }
        }

        /// <summary>
        /// Gets the dictonary object that contains all the prices
        /// </summary>
        public Dictionary<int, TimePrice> Prices
        {
            get { return prices; }
            private set { prices = value; }
        }

        /// <summary>
        /// PriceTable constructor
        /// Populates the prices dictonary 
        /// </summary>
        private PriceTable()
        {
            prices = new Dictionary<int, TimePrice>();
            conferenceRoomPrice = 1000;
        }

        /// <summary>
        /// Sets a price based on season, room count and weekly
        /// </summary>
        /// <param name="roomCount">The amount of Rooms</param>
        /// <param name="season">The season</param>
        /// <param name="weekly">If it's weekly or daily</param>
        /// <param name="newValue">the new amount to be assigned</param>
        public void setPrice(int roomCount, Season season, bool weekly, double newValue)
        {
            TimePrice price = prices[roomCount];

            int index = weekly ? 1 : 0;

            if (season == Season.HIGH)     price.High[index] = newValue;
            else if (season == Season.MID) price.Mid[index] = newValue;
            else if (season == Season.LOW) price.Low[index] = newValue;
        }

        /// <summary>
        /// Initializes the object, saves and loads if necessary
        /// </summary>
        public void initialize()
        {
            if (File.Exists(FILE))
            {
                load();
            }
            else
            {
                populate();
                save();
            }
        }

        /// <summary>
        /// Populates the prices table - currently used if the file cannot be found
        /// </summary>
        public void populate()
        {

            prices.Add(1, new TimePrice(
                new double[] { 40, 200 },
                new double[] { 35, 175 },
                new double[] { 20, 150 }));

            prices.Add(2, new TimePrice(
                new double[] { 50, 250 },
                new double[] { 45, 225 },
                new double[] { 30, 200 }));

            prices.Add(3, new TimePrice(
                new double[] { 60, 300 },
                new double[] { 50, 275 },
                new double[] { 40, 250 }));


            prices.Add(4, new TimePrice(
                new double[] { 70, 350 },
                new double[] { 60, 325 },
                new double[] { 50, 300 }));
        }

        /// <summary>
        /// Get's the high price for the room count and weekly
        /// </summary>
        /// <param name="roomCount">The room count</param>
        /// <param name="weekly">If it's weekly or not</param>
        /// <returns>the price</returns>
        public double getHighPrice(int roomCount, bool weekly)
        {
            return getPriceFor(roomCount, DateTime.Parse("06/06/2015"), weekly);

        }

        /// <summary>
        /// Get's the mid price for the room count and weekly
        /// </summary>
        /// <param name="roomCount">The room count</param>
        /// <param name="weekly">If it's weekly or not</param>
        /// <returns>the price</returns>
        public double getMidPrice(int roomCount, bool weekly)
        {
            return getPriceFor(roomCount, DateTime.Parse("05/05/2015"), weekly);
        }

        /// <summary>
        /// Get's the low price for the room count and weekly
        /// </summary>
        /// <param name="roomCount">The room count</param>
        /// <param name="weekly">If it's weekly or not</param>
        /// <returns>the price</returns>
        public double getLowPrice(int roomCount, bool weekly)
        {
            return getPriceFor(roomCount, DateTime.Parse("01/01/2015"), weekly);
        }

        /// <summary>
        /// Loads the prices from a json file
        /// </summary>
        public void load()
        {
            prices = (Dictionary<int, TimePrice>)JsonManager.load<Dictionary<int, TimePrice>>(FILE);
            conferenceRoomPrice = (double)JsonManager.load<double>(CONFERENCE_FILE);
        }

        /// <summary>
        /// Saves the prices to a json file
        /// </summary>
        public void save()
        {
            JsonManager.save(FILE, prices);
            JsonManager.save(CONFERENCE_FILE, conferenceRoomPrice);
        }

        /// <summary>
        /// Gets a price for the room type based on a date and if weekly or not
        /// </summary>
        /// <param name="roomCount">the amount of rooms</param>
        /// <param name="date">the date</param>
        /// <param name="weekly">if you are checking weekly</param>
        /// <returns>The price as a double</returns>
        private double getPriceFor(int roomCount, DateTime date, bool weekly)
        {
            parameterCheck(roomCount);
            return prices[roomCount].getAppropriatePrice(date, weekly);
        }

        /// <summary>
        /// Gets a price for a specific room count and a start date + end date
        /// </summary>
        /// <param name="roomCount">The amount of rooms - up to 4</param>
        /// <param name="startDate">The start date</param>
        /// <param name="endDate">The end date</param>
        /// <returns>the total price </returns>
        public double getPriceFor(int roomCount, DateTime startDate, DateTime endDate)
        {
            parameterCheck(roomCount);

            int days = (endDate - startDate).Days;
            if (days < 1) { throw new Exception("Cannot get a price for a negative amount of days/weeks"); }

            int weeks = days / 7;
            int lastDays = days - (weeks * 7);

            DateTime currentDate = startDate;

            double total = 0;

            for (int i = 0; i < weeks; i++)
            {
                total += getPriceFor(roomCount, startDate, true);
                startDate = startDate.AddDays(7);
            }

            for (int i = 0; i < lastDays; i++)
            {
                total += getPriceFor(roomCount, startDate, false);
                startDate = startDate.AddDays(1);
            }

            return total;
        }

        /// <summary>
        /// Parameter check will check if a value is between 1 and 4
        /// 
        /// If not then throw an exception
        /// </summary>
        /// <param name="value">The value to check</param>
        private void parameterCheck(int value)
        {
            if (value <= 0 || value > 4)
            {
                throw new Exception("Room count must be between 1 and 4");
            }
        }

    }
}
