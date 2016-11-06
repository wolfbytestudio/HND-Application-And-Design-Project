using FinalPoject.com;
using FinalPoject.ui.controls;
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
    /// Interaction logic for Transactions.xaml
    /// </summary>
    public partial class Transactions : Page
    {

        /// <summary>
        /// The library object
        /// </summary>
        private Library library;

        /// <summary>
        /// Transaction constructor
        /// </summary>
        public Transactions()
        {
            InitializeComponent();
            library = Library.Get;
        }
        
        /// <summary>
        /// Main menu button up event
        /// </summary>
        private void btnMainMenu_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow.frame.GoBack();
        }

        /// <summary>
        /// Page loaded event
        /// </summary>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(Transaction t in library.Transactions)
            {
                stkTransactions.Children.Add(new TransactionControl(t));
            }
        }
    }
}
