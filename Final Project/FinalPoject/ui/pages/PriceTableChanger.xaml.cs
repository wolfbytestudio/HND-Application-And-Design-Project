using FinalPoject.com.hotel;
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
    /// Interaction logic for PriceTableChanger.xaml
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public partial class PriceTableChanger : Page
    {

        /// <summary>
        /// the PriceTable object
        /// </summary>
        private PriceTable priceTable;

        /// <summary>
        /// PriceTableChanger constructor
        /// </summary>
        public PriceTableChanger()
        {
            InitializeComponent();
            priceTable = PriceTable.Get;
            loadPrices();
        }

        /// <summary>
        /// Loads the prices from the price table
        /// </summary>
        public void loadPrices()
        {
            //this is bad code
            txt1HighDaily.Text = "" + priceTable.getHighPrice(1, false);
            txt1HighWeekly.Text = "" + priceTable.getHighPrice(1, true);
            txt1MidDaily.Text = "" + priceTable.getMidPrice(1, false);
            txt1MidWeekly.Text = "" + priceTable.getMidPrice(1, true);
            txt1LowDaily.Text = "" + priceTable.getLowPrice(1, false);
            txt1LowWeekly.Text = "" + priceTable.getLowPrice(1, true);

            txt2HighDaily.Text = "" + priceTable.getHighPrice(2, false);
            txt2HighWeekly.Text = "" + priceTable.getHighPrice(2, true);
            txt2MidDaily.Text = "" + priceTable.getMidPrice(2, false);
            txt2MidWeekly.Text = "" + priceTable.getMidPrice(2, true);
            txt2LowDaily.Text = "" + priceTable.getLowPrice(2, false);
            txt2LowWeekly.Text = "" + priceTable.getLowPrice(2, true);

            txt3HighDaily.Text = "" + priceTable.getHighPrice(3, false);
            txt3HighWeekly.Text = "" + priceTable.getHighPrice(3, true);
            txt3MidDaily.Text = "" + priceTable.getMidPrice(3, false);
            txt3MidWeekly.Text = "" + priceTable.getMidPrice(3, true);
            txt3LowDaily.Text = "" + priceTable.getLowPrice(3, false);
            txt3LowWeekly.Text = "" + priceTable.getLowPrice(3, true);

            txt4HighDaily.Text = "" + priceTable.getHighPrice(4, false);
            txt4HighWeekly.Text = "" + priceTable.getHighPrice(4, true);
            txt4MidDaily.Text = "" + priceTable.getMidPrice(4, false);
            txt4MidWeekly.Text = "" + priceTable.getMidPrice(4, true);
            txt4LowDaily.Text = "" + priceTable.getLowPrice(4, false);
            txt4LowWeekly.Text = "" + priceTable.getLowPrice(4, true);
        }

        /// <summary>
        /// Save button mouse up
        /// 
        /// saves all the prices to a 
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnSave_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try//This code could have been a lot more efficiant
            {
                priceTable.setPrice(1, Season.HIGH, false, double.Parse( txt1HighDaily.Text));
                priceTable.setPrice(1, Season.HIGH, true, double.Parse(  txt1HighWeekly.Text));
                priceTable.setPrice(1, Season.MID, false, double.Parse(  txt1MidDaily.Text));
                priceTable.setPrice(1, Season.MID, true, double.Parse(   txt1MidWeekly.Text));
                priceTable.setPrice(1, Season.LOW, false, double.Parse(  txt1LowDaily.Text));
                priceTable.setPrice(1, Season.LOW, true, double.Parse(   txt1LowWeekly.Text));

                priceTable.setPrice(2, Season.HIGH, false, double.Parse( txt2HighDaily.Text));
                priceTable.setPrice(2, Season.HIGH, true, double.Parse(  txt2HighWeekly.Text));
                priceTable.setPrice(2, Season.MID, false, double.Parse(  txt2MidDaily.Text));
                priceTable.setPrice(2, Season.MID, true, double.Parse(   txt2MidWeekly.Text));
                priceTable.setPrice(2, Season.LOW, false, double.Parse(  txt2LowDaily.Text));
                priceTable.setPrice(2, Season.LOW, true, double.Parse(   txt2LowWeekly.Text));

                priceTable.setPrice(3, Season.HIGH, false, double.Parse( txt3HighDaily.Text));
                priceTable.setPrice(3, Season.HIGH, true, double.Parse(  txt3HighWeekly.Text));
                priceTable.setPrice(3, Season.MID, false, double.Parse(  txt3MidDaily.Text));
                priceTable.setPrice(3, Season.MID, true, double.Parse(   txt3MidWeekly.Text));
                priceTable.setPrice(3, Season.LOW, false, double.Parse(  txt3LowDaily.Text));
                priceTable.setPrice(3, Season.LOW, true, double.Parse(   txt3LowWeekly.Text));

                priceTable.setPrice(4, Season.HIGH, false, double.Parse( txt4HighDaily.Text));
                priceTable.setPrice(4, Season.HIGH, true, double.Parse(  txt4HighWeekly.Text));
                priceTable.setPrice(4, Season.MID, false, double.Parse(  txt4MidDaily.Text));
                priceTable.setPrice(4, Season.MID, true, double.Parse(   txt4MidWeekly.Text));
                priceTable.setPrice(4, Season.LOW, false, double.Parse(  txt4LowDaily.Text));
                priceTable.setPrice(4, Season.LOW, true, double.Parse(   txt4LowWeekly.Text));

                priceTable.save();

                lblMessage.Text = "Successfully updated the price table";
                lblMessage.Visibility = System.Windows.Visibility.Visible;
            }
            catch
            {
                lblMessage.Text = "Error updating the price tabel!";
                lblMessage.Visibility = System.Windows.Visibility.Visible;
            }
           
        }

        /// <summary>
        /// Save button mouse up event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void btnSave_Copy_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow.frame.GoBack();
        }
    }
}
