using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using database;
using Entities;

namespace BusinessLogic
{
   public class Accountentity
    {

        public Accountentity()
        {
        }
        public void Insert()
        {
            Console.WriteLine("hello");
            int id = Int32.Parse(Console.ReadLine());
            int branch = Int32.Parse(Console.ReadLine());
            string accholder = Console.ReadLine();
            int bal = Int32.Parse(Console.ReadLine());

            Accounte a= new Accounte();
           
            a.Insert(id, accholder,branch,bal);



        }


        public void Deposit()
        {
            Console.WriteLine("enter the money to be deposited \n" + "enter the id where money to be deposited");
            int bal = int.Parse(Console.ReadLine());
            int id = Int32.Parse(Console.ReadLine());
            Accounte a = new Accounte();
            int pbal = a.SearchData(id);
            Console.WriteLine("previous balance is {0}", pbal);
            if (pbal != 0)
            {
                pbal = pbal + bal;
                try
                {
                    a.Update(id, pbal);
                    Console.WriteLine("updated balance is {0}", pbal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
        public void Withdraw()
        {

            Console.WriteLine("enter the id \n" + "enter the  money to be withdrawn");
            int id = Int32.Parse(Console.ReadLine());
            int bal = Int32.Parse(Console.ReadLine());
            Accounte a = new Accounte();
            int b = a.SearchData(id);
            int t = a.SearchType(id);
            int minBalance;
            int flag = 0;
     
            if (b != 0)
            {
                Console.WriteLine("previous balance is {0}", b);
                if (t == 0)
                {
                    minBalance = 1000;
                    if (b >= minBalance && bal < b)
                    {
                        Console.WriteLine("Saving Account");
                        b = b - bal;
                        try
                        {
                            a.Update(id, b);
                            Console.WriteLine("updated balance is {0}", b);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        flag = 1;

                    }

                }
                else if (t == 1)
                {

                    if (bal < b)
                    {
                        Console.WriteLine("Current Account");
                        b = b - bal;
                        try
                        {
                            a.Update(id, b);
                            Console.WriteLine("updated balance is {0}", b);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        flag = 1;

                    }

                }
                else
                {

                    Console.WriteLine("DMAT Account");

                    int bala = b - bal;
                    if (bala > -10000)
                    {
                        b = b - bal;
                        try
                        {
                            a.Update(id, b);
                            Console.WriteLine("updated balance is {0}", b);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        flag = 1;
                    }

                }
                if (flag == 0)
                {
                    Console.WriteLine("Cannot withdraw money");
                }

            }
    
        }
        public void Search()
        {
         
            Accounte a = new Accounte();
            int id = Int32.Parse(Console.ReadLine());
            int pos=a.SearchData(id);
            if(pos!=-1)
            Console.WriteLine("uaer exists");
                else
                  Console.WriteLine("uaer dont exists");

        }
        public void Display()
        {
            int id = Int32.Parse(Console.ReadLine());
            Accounte a = new Accounte();
            Accounts acc =a.DisplayData(id);
            Console.WriteLine("Account id is {0} \n Holder is{1} \n Account branch is {2} \n  balance amount is {3}", acc._accountId, acc._accountHolder, acc._accountBranch, acc._balanceAmount);
        }
        public void CalculateInterest()

        {
            Accounte a = new Accounte();
            int id = Int32.Parse(Console.ReadLine());
            int branch = a.SearchType(id);


            int bal = a.SearchData(id);

            if (branch == 0)
            {

                bal = bal + (int)(bal * (0.04)) / 100;
                try
                {
                   a.Update(id, bal);
                    Console.WriteLine("{0}", bal);
                }

                catch (Exception ob)
                {

                    Console.WriteLine("update could not be performed");

                    Console.WriteLine(ob.Message);

                }
            }
            else if (branch == 1)
            {
                bal = bal + (int)(bal * 0.01) / 100;
                try
                {
                    a.Update(id, bal);
                }
                catch (Exception ob)
                {

                    Console.WriteLine("update could not be performed");

                    Console.WriteLine(ob.Message);

                }

            }
            else
            {
                Console.WriteLine("Cannot calculate interest on DMAT account");

            }



        }
    }
}
