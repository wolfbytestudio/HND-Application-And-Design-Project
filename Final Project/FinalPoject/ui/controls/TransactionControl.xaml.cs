using FinalPoject.com;
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

namespace FinalPoject.ui.controls
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {

        /// <summary>
        /// The transaction object
        /// </summary>
        private Transaction transaction;

        /// <summary>
        /// Constructor for transaction
        /// </summary>
        /// <param name="transaction">The transaction</param>
        public TransactionControl(Transaction transaction)
        {
            this.transaction = transaction;
            InitializeComponent();

            lblAmount.Text = "£" + transaction.Amount;
            lblDate.Text = transaction.Date.ToShortDateString();
            lblLength.Text = transaction.Length + "";
            lblMemberId.Text = transaction.MemberId + "";
            lblRoomName.Text = transaction.RoomName;
            lblTransactionId.Text = transaction.TransactionId + "";
        }
    }
}
