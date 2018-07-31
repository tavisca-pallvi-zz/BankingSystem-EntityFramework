using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace database
{
    interface Idbinterface
    { 
        void Insert(int id, string name, int balance, int banktype);
        
        void Update(int id, int balance);
      


        int SearchData(int id);
       
        Accounts DisplayData(int id);


        int SearchType(int id);

    }
}
