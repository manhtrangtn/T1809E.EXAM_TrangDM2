using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1809E.EXAM_TrangDM2.Entities;
using T1809E.EXAM_TrangDM2.Utils;

namespace T1809E.EXAM_TrangDM2.Models
{
    class ContactModel
    {
        private SQLiteConnection dbConnect = DbConnection.CreateConnection().SQLiteConnection;

        public bool SaveContact(Contact Contact)
        {
            using (var statment = dbConnect.Prepare(Constants.CREATE_CONTACT))
            {
                statment.Bind(1, Contact.Name);
                statment.Bind(2, Contact.Phone);
                return statment.Step() == SQLiteResult.OK;
            }
        }

        public Contact GetContact(string Name)
        {
            Contact Contact = new Contact();
            using (var statment = dbConnect.Prepare(Constants.GET_CONTACT))
            {
                statment.Bind(1, Name);
                statment.Step();
                Contact.Name = (string)statment[0];
                Contact.Phone = (string)statment[1];
                return Contact;
            }
        }

        public Contact GetContactByPhone(string Phone)
        {
            Contact Contact = new Contact();
            using (var statment = dbConnect.Prepare(Constants.GET_CONTACT_BYPHONE))
            {
                statment.Bind(1, Phone);
                statment.Step();
                Contact.Name = (string)statment[0];
                Contact.Phone = (string)statment[1];
                return Contact;
            }
        }


        public List<Contact> GetContacts()
        {
            List<Contact> Contacts = new List<Contact>();
            
            using (var statment = dbConnect.Prepare(Constants.GET_CONTACTS))
            {
                while (SQLiteResult.ROW == statment.Step())
                {
                    Contact Contact = new Contact();
                    Contact.Name = (string)statment[0];
                    Contact.Phone = (string)statment[1];
                    Contacts.Add(Contact);
                }
            }
            return Contacts;

        }
    }
}
