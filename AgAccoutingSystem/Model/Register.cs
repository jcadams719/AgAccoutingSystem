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

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private string document;
        public string Document
        {
            get { return document; }
            set { document = value; }
        }

        private string subAcct;
        public string SubAcct
        {
            get { return subAcct; }
            set { subAcct = value; }

        }

        private string vendor;
        public string Vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }

        private string item; 
        public string Item
        {
            get { return item; }
            set { item = value; }

        }

        private float deposit;
        public float Deposit
        {
            get { return deposit; }
            set { deposit = value; }

        }

        private float expense;

        public float Expense
        {
            get { return expense; }
            set { expense = value; }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }

        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string comment;
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        private string pending;
        public string Pending
        {
            get { return pending; }
            set { pending = value; }
        }
    }
}
