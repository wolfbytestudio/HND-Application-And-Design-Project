using FinalPoject.com;
using FinalPoject.com.hotel;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;


namespace FinalPoject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// Static instance of the frame for pages to share
        /// </summary>
        public static Frame frame;

        /// <summary>
        /// Kernal32 Console opener
        /// </summary>
        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        /// <summary>
        /// Kernal32 Console closer
        /// </summary>
        [DllImport("Kernel32")]
        public static extern void FreeConsole();

        /// <summary>
        /// The library object
        /// </summary>
        private Library library;

        /// <summary>
        /// The MainWindow Constructor
        /// </summary>
        public MainWindow()
        {
            AllocConsole();

            InitializeComponent();

            frame = frmMain;

            TestHarness.load();

            PriceTable p = PriceTable.Get;
            p.initialize();

            library = Library.Get;
            library.initialize();
        }

        /// <summary>
        /// Saves all content when the window is closed
        /// </summary>
        /// <param name="sender">The object sender</param>
        /// <param name="e">The event</param>
        private void frmMainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            library.saveContent();
        }
    }
}
