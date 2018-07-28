using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database;

namespace BusinessLogic
{
    
    
   public class Accountb {

        Data d = new Data();

        public void Add()
        {
            int id = Int32.Parse(Console.ReadLine());
            int branch = Int32.Parse(Console.ReadLine());
            string accholder = Console.ReadLine();
            float bal =float.Parse( Console.ReadLine());
            Console.WriteLine("hello");
            d.Insert(id, accholder, bal, branch);
          //  int n = d.SearchData(id);
         //   Console.WriteLine("{0}",n);
            //if(n==)

            d.Close();
        }
        public void Deposit()
        {
            Console.WriteLine("enter the money to be deposited");
            Console.WriteLine("enter the id where money to be deposited");
            int id = Int32.Parse(Console.ReadLine());
            // float bal = Int32.Parse(Console.ReadLine());
           int r= d.SearchData(id);


            Console.WriteLine("{0}", r);
        }

            /*public void SearchData()
              {
                  Data d = new Data();
                  int id = Int32.Parse(Console.ReadLine());
                  int branch = Int32.Parse(Console.ReadLine());
                  string accholder = Console.ReadLine();
                  float bal = float.Parse(Console.ReadLine());
                  Console.WriteLine("hello");
                  d.Insert(id, accholder, bal, branch);
                  d.Close();
              }
              */

            /*
             public void WithrawMoney()
            {
                int id, amount;
                Console.WriteLine("Enter user id");
                id = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter the amount to be withdrawn");
                amount = Int32.Parse(Console.ReadLine());
                int bal=search(id);
                bal = bal + amount;
                update(id, bal);

            }




            public Account(int _accountId, int _accountBranch, string _accountHolder, double _balanceAmount)
                {
                    this._accountBranch = _accountBranch;
                    this._accountId = _accountId;
                    this._accountHolder = _accountHolder;
                    this._balanceAmount = _balanceAmount;
                }

                public int getAccId()
                {
                    return this._accountId;
                }


                public int getAccBranch()
                {

                    return this._accountBranch;
                }


                public string getAccHolder()
                {
                    return this._accountHolder;
                }


                public double getBalAmount()
                {
                    return this._balanceAmount;
                }


                public void setBalAmount(double bal)
                {
                    this._balanceAmount = bal;
                }

            }
        */
        }


}
