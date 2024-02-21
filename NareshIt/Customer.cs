using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NareshIt
{
    internal class Customer
    {
       public int CustId;
        bool Status;
        string Cname;
        double Balance;
        public Customer(int CustId, bool Status,string Cname,double Balance)
        {
            this.CustId = CustId;
            this.Status = Status;
            this.Cname  =Cname;
            this.Balance = Balance;
        }


    }
}
