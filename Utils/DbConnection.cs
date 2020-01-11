using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1809E.EXAM_TrangDM2.Utils
{
    class DbConnection
    {
        private static DbConnection _instance;
        public SQLiteConnection SQLiteConnection { get; set; }
        public DbConnection()
        {
            SQLiteConnection = new SQLiteConnection("mydb.db");
            CreateTables();
        }

        public void CreateTables()
        {
            CreateMemberTable(Constants.CREATE_CONTACT_TABLE);
        }

        public void CreateMemberTable(String Query)
        {
            using (var statment = SQLiteConnection.Prepare(Query))
            {
                statment.Step();
            }

        }

        public static DbConnection CreateConnection()
        {
            if (_instance == null)
            {
                _instance = new DbConnection();
            }
            return _instance;
        }
    }
}
