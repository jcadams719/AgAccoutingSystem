using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgAccoutingSystem
{
    class Query
    {

        public Register[] getTransaction(int accountID)
        {
            string getTrans = "SELECT * FROM REGISTER LEFT JOIN ACCOUNTS ON REGISTER.ACCOUNTID = ACCOUNTS.ACCOUNTID WHERE ACCOUNTS.ACCOUNTID = "+ accountID +"";
            Console.WriteLine(getTrans);
            Register[] transactions = new Register[1000];



            return transactions;
        }
    }
}
