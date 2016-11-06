using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for HotelButton.xaml
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public partial class HotelButton : UserControl
    {
        
        /// <summary>
        /// The button text getter + setter
        /// </summary>
        [Category("Custom Controls"),
            DisplayName("Button Text"),
            Browsable(true),
            EditorBrowsable(EditorBrowsableState.Always),
            Bindable(true),
            DefaultValue("Button")]
        public string ButtonText
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        /// <summary>
        /// Checks if the button is filled with colour
        /// </summary>
        [Category("Custom Controls"),
        DisplayName("Fill with colour?"),
        Browsable(true),
        EditorBrowsable(EditorBrowsableState.Always),
        Bindable(true),
        DefaultValue(false)]
        public bool Filled
        {
            get; set;
        }

        /// <summary>
        /// The base colour of the borders and filled button
        /// </summary>
        [Category("Custom Controls"),
        DisplayName("Base Color:"),
        Browsable(true),
        EditorBrowsable(EditorBrowsableState.Always),
        Bindable(true),
        DefaultValue("#58C930")]
        public string BaseColor
        {
            get; set;
        }

        /// <summary>
        /// HotelButton Constructor
        /// </summary>
        public HotelButton()
        {
            BaseColor = "#58C930";
            InitializeComponent();
        }

        /// <summary>
        /// Button mouse enter event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void ctrlButton_MouseEnter(object sender, MouseEventArgs e)
        {
            ctrlButton.Opacity = 1;
        }

        /// <summary>
        /// Button mouse leave event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void ctrlButton_MouseLeave(object sender, MouseEventArgs e)
        {
            ctrlButton.Opacity = .65;
        }

        /// <summary>
        /// The button loaded event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void ctrlButton_Loaded(object sender, RoutedEventArgs e)
        {
            if (Filled)
            {
                recButton.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(BaseColor));
            }

            recButton.Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(BaseColor));
        }
    }
}
