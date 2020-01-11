using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1809E.EXAM_TrangDM2.Entities;
using T1809E.EXAM_TrangDM2.Models;

namespace T1809E.EXAM_TrangDM2.Services
{
    class ContactService: IContactService
    {
        private ContactModel ContactModel = new ContactModel();

        public bool Create(Contact Contact)
        {
            return ContactModel.SaveContact(Contact);
        }

        public Contact GetContact(string name)
        {
            return ContactModel.GetContact(name);
        }
        public Contact GetContactByPhone(string phone)
        {
            return ContactModel.GetContactByPhone(phone);
        }

        public List<Contact> GetContacts()
        {
            return ContactModel.GetContacts();
        }
    }
}
