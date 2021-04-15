using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgAccoutingSystem
{
    class Register
    {
        private int transactionID;
        public int TransactionID
        {
            get { return transactionID; }
            set { transactionID = value;  }
        }

        private int code;
        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        private int accountID;
        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

    }
}
