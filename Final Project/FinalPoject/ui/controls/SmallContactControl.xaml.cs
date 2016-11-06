using FinalPoject.com.people;
using FinalPoject.ui.pages;
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
    /// Interaction logic for SmallContactControl.xaml
    /// 
    /// Author - Zack Davidson - 30008095
    /// </summary>
    public partial class SmallContactControl : UserControl
    {
        /// <summary>
        /// Static SmallContactControl to check the last selected
        /// contact control - used for turning off the selected
        /// </summary>
        private static SmallContactControl selected;

        /// <summary>
        /// The contact attatched to the SmallContactControl
        /// </summary>
        private Person contact;

        /// <summary>
        /// The window owner
        /// </summary>
        private Contacts owner;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="contact">the person</param>
        /// <param name="owner">the page owner</param>
        public SmallContactControl(Person contact, Contacts owner)
        {
            InitializeComponent();
            this.contact = contact;
            this.owner = owner;
            lblId.Content = "User ID: " + contact.MemberId;
            lblName.Content = "Name: " + contact.Name;
        }

        /// <summary>
        /// The SmallContactControl mouse enter event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void ctrlPerson_MouseEnter(object sender, MouseEventArgs e)
        {
            ctrlPerson.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3F4044"));
        }

        /// <summary>
        /// Selects the SmallContactControl
        /// </summary>
        public void select()
        {
            if (selected != null)
                selected.unselect();

            selected = this;
            owner.select(contact);
            ctrlPerson.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2B2C30"));

        }

        /// <summary>
        /// Unselects the SmallContactControl
        /// </summary>
        public void unselect()
        {
                ctrlPerson.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#17181C"));
        }

        /// <summary>
        /// The SmallContactControl mouse leave event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void ctrlPerson_MouseLeave(object sender, MouseEventArgs e)
        {
            if(selected == sender)
                ctrlPerson.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2B2C30"));
            else
            ctrlPerson.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#17181C"));
        }

        /// <summary>
        /// The SmallContactControl mouse up event
        /// </summary>
        /// <param name="sender">the object sender</param>
        /// <param name="e">the event</param>
        private void ctrlPerson_MouseUp(object sender, MouseButtonEventArgs e)
        {
            select();
        }
    }
}
