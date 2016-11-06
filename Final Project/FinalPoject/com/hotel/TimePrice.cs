using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoject.com.hotel
{

    /// <summary>
    /// Time price object contains a high - daily/weekly,
    /// mid - daily/weekly, low - daily/weekly
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public class TimePrice
    {

        /// <summary>
        /// The high totals for daily and weekly
        /// daily = index 0, weekly = index 1
        /// </summary>
        private double[] high;

        /// <summary>
        /// The mid totals for daily and weekly
        /// daily = index 0, weekly = index 1
        /// </summary>
        private double[] mid;

        /// <summary>
        /// The low totals for daily and weekly
        /// daily = index 0, weekly = index 1
        /// </summary>
        private double[] low;

        /// <summary>
        /// Getter and Setter for high
        /// </summary>
        public double[] High
        {
            set { high = value; }
            get { return high; }
        }

        /// <summary>
        /// Getter and Setter for mid
        /// </summary>
        public double[] Mid
        {
            set { mid = value; }
            get { return mid; }
        }

        /// <summary>
        /// Getter and Setter for low
        /// </summary>
        public double[] Low
        {
            set { low = value; }
            get { return low; }
        }

        /// <summary>
        /// Constructor for TimePrice
        /// </summary>
        /// <param name="high">the new high values</param>
        /// <param name="mid">the new mid values</param>
        /// <param name="low">the new low values</param>
        public TimePrice(double[] high, double[] mid, double[] low)
        {
            this.high = high;
            this.mid = mid;
            this.low = low;
        }

        /// <summary>
        /// All the high term months
        /// </summary>
        private static readonly int[] HIGH = { 6, 7, 8 };

        /// <summary>
        /// All the mid term months
        /// </summary>
        private static readonly int[] MID = { 5, 9 };

        /// <summary>
        /// Gets the appropriate price depending on the date and
        /// if it's a weekly inquiry 
        /// </summary>
        /// <param name="date">The date to check</param>
        /// <param name="weekly">Check if it's weekly or daily</param>
        /// <returns>the price</returns>
        public double getAppropriatePrice(DateTime date, bool weekly)
        {
            int index = weekly ? 1 : 0;

            foreach(int val in HIGH)
            {
                if (date.Month == val)
                {
                    return high[index];
                }
                    
            }

            foreach(int val in MID)
            {
                if (date.Month == val)
                {
                    return mid[index];
                }
            }

            return low[index];
        }

    }
}
