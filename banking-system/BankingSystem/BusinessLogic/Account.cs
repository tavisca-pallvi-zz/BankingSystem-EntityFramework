using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database;
using Entities;

namespace BusinessLogic
{


    public class Accountb
    {

        Data dataAccess = new Data();

        public void Add()
        {
            Console.WriteLine("hello");
            int id = Int32.Parse(Console.ReadLine());
            int branch = Int32.Parse(Console.ReadLine());
            string accholder = Console.ReadLine();
            int bal = Int32.Parse(Console.ReadLine());
            Console.WriteLine("hello");
            try
            {
                dataAccess.Insert(id, accholder, bal, branch);

            }
        

            catch (Exception ob)
            {

                Console.WriteLine("primary constraint");

                Console.WriteLine(ob.Message);

            }


            // dataAccess.Close();
        }

        public int Search()
        {
            int id = Int32.Parse(Console.ReadLine());

            return dataAccess.SearchData(id);


        }
        public void Display()
        {
            int id = Int32.Parse(Console.ReadLine());
            Accounts acc= dataAccess.DisplayData(id);
            Console.WriteLine("Account id is {0} \n Holder is{1} \n Account branch is {2} \n  balance amount is {3}", acc._accountId, acc._accountHolder,acc._accountBranch,acc._balanceAmount);
        }
        public void Deposit()
        {
            Console.WriteLine("enter the money to be deposited \n" + "enter the id where money to be deposited");
            int bal = int.Parse(Console.ReadLine());
            int id = Int32.Parse(Console.ReadLine());
            int pbal = CheckUser(id);
            Console.WriteLine("previous balance is {0}", pbal);
            if (pbal != 0)
            {
                pbal = pbal + bal;
                try
                {
                    dataAccess.Update(id, pbal);
                    Console.WriteLine("updated balance is {0}", pbal);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
                   
            }

        
        public int CheckUser(int id)
        {

            int pbal = dataAccess.SearchData(id);
            if (pbal == -1)
            {
                Console.WriteLine("user dont exists");
                return 0;
            }
            return pbal;

        }




        public void Withdraw()
        {
            Console.WriteLine("enter the money to be withdrawn \n" + "enter the id where money to be withdrawn");
            int bal = int.Parse(Console.ReadLine());
            int id = Int32.Parse(Console.ReadLine());

            int t = dataAccess.SearchType(id);
            int minBalance;
            int flag = 0;
            int pbal = CheckUser(id);
            if (pbal != 0)
            {
                Console.WriteLine("previous balance is {0}", pbal);
                if (t == 0)
                {
                    minBalance = 1000;
                    if (pbal >= minBalance && bal < pbal)
                    {
                        Console.WriteLine("Saving Account");
                        pbal = pbal - bal;
                        try
                        {
                            dataAccess.Update(id, pbal);
                            Console.WriteLine("updated balance is {0}", pbal);

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

                    if (bal < pbal)
                    {
                        Console.WriteLine("Current Account");
                        pbal = pbal - bal;
                        try
                        {
                            dataAccess.Update(id, pbal);
                            Console.WriteLine("updated balance is {0}", pbal);
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

                    int bala = pbal - bal;
                    if (bala > -10000)
                    {
                        pbal = pbal - bal;
                        try
                        {
                            dataAccess.Update(id, pbal);
                            Console.WriteLine("updated balance is {0}", pbal);
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

        public void CalculateInterest()

        {
            int id = Int32.Parse(Console.ReadLine());
            int branch = dataAccess.SearchType(id);


            int bal = dataAccess.SearchData(id);

            if (branch == 0)
            {

                bal = bal + (int)(bal * (0.04)) / 100;
                try
                {
                    dataAccess.Update(id, bal);
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
                    dataAccess.Update(id, bal);
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
