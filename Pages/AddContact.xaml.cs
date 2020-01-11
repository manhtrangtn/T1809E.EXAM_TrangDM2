using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using T1809E.EXAM_TrangDM2.Entities;
using T1809E.EXAM_TrangDM2.Services;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1809E.EXAM_TrangDM2.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddContact : Page
    {
        private readonly IContactService contactService = new ContactService();
        public AddContact()
        {
            this.InitializeComponent();
        }

        private void AddContactHandle(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact()
            {
                Name = Name.Text,
                Phone = Phone.Text
            };
            if (!string.IsNullOrEmpty(Phone.Text))
            {
                if (contactService.GetContactByPhone(contact.Phone).Phone == null)
                {
                    contactService.Create(contact);
                    AlertContact.Text = "Add contact successfully!";
                }
                else
                {
                    AlertContact.Text = "This phonenumber already exist!";
                }
            }
            else
            {
                AlertContact.Text = "Phone number may not be null!";
            }
        }
    }
}
