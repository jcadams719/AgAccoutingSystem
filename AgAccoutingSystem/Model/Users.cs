using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgAccoutingSystem
{
    class Users
    {
        private string userID;
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string discipline;
        public string Discipline
        {
            get { return discipline; }
            set { discipline = value; }
        }

        private string permissions;
        public string Permissions
        {
            get { return permissions; }
            set { permissions = value; }
        }

    }
}
