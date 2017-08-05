using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication5.Models
{
    public class Information
    {
       public List<Account> Accounts;

        public Information()
        {
            Accounts = new List<Account>();
            Accounts.Add(new Account {Id = 1, Name = " sd31",Age =12});
            Accounts.Add(new Account {Id = 1, Name = " sd13",Age =12});
            Accounts.Add(new Account {Id = 1, Name = " sd1eq2",Age =12});
        }
    }
}