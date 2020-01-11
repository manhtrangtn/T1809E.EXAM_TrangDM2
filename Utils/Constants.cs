using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1809E.EXAM_TrangDM2.Utils
{
    class Constants
    {
        public static readonly string CREATE_CONTACT_TABLE = @"Create table if not exists Contact (Name varchar(200), Phone varchar(50) primary key not null)";
        public static readonly string CREATE_CONTACT = @"insert into Contact values(?,?)";
        public static readonly string GET_CONTACT = @"select * from Contact where Name like ? LIMIT 1";
        public static readonly string GET_CONTACT_BYPHONE = @"select * from Contact where Phone= ?";
        public static readonly string GET_CONTACTS = @"select * from Contact";
    }
}
