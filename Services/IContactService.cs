using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1809E.EXAM_TrangDM2.Entities;

namespace T1809E.EXAM_TrangDM2.Services
{
    interface IContactService
    {
        bool Create(Contact Contact);
        Contact GetContact(string name);
        
        Contact GetContactByPhone(string phone);
        List<Contact> GetContacts();
    }
}
