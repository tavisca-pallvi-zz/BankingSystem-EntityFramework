using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;



namespace database
{
   public class Accounte : Idbinterface
    {
        AccountdbEntities1 entity = new AccountdbEntities1();
        public Accounte()
        {

        }

        public void Insert(int id, string name, int balance, int banktype)
        {
          
            var account = new accountbd { name = name, id = id, banktype = banktype, balance = balance };
            entity.accountbds.Add(account);
            entity.SaveChanges();
            
            
        }

        public void Update(int id, int bal)
        {
          var search = entity.accountbds.Find(id);
            if (search != null)
            {
                search.balance = bal;
            }
            entity.SaveChanges();
        }


        public int SearchData(int id)
        {
            var search = entity.accountbds.Find(id);
            if (search != null){ 
            int bal = search.balance;
                return search.balance;
            }
            return - 1;
        }
        public Accounts DisplayData(int id)
        {
            int pos= entity.accountbds.Find(id).id;
            string name = entity.accountbds.Find(id).name;
            int bal = entity.accountbds.Find(id).balance;
            int  banktype= entity.accountbds.Find(id).banktype;
            return new Accounts(pos, banktype, name, bal);
        }

        public int SearchType(int id)
        {

            var search = entity.accountbds.Find(id);
            int type = search.banktype;

            return type;

        }
       


    }
   
}

