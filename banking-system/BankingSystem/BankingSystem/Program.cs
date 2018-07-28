using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountDetails;
using AccountHolders;
using database;
using BusinessLogic;


namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)


        {
            User user = new User();
            //  Data ob = new Data();
            Data d = new Data();
            d.Connect();
            /*float amount;
            int id = 0;
            int f = 1;
            char c;
            while (f == 1)
             {
                 Console.WriteLine("Press 'y' to continue");
                 c = Console.ReadKey().KeyChar;
                 if (c == 'n')
                 {
                     f = 0;
                     break;
                 }
                 Console.WriteLine("Press 'A' if you want to see Account Details \n Press 'S' if you want to search for an Account \n Press 'W' if you want to withdraw money \n  Press 'D' if you want to deposit mooney \n Press 'C' if you want to calculate interest");
                 Console.WriteLine("Enter operation you want to perform");
                 // char Case = Console.ReadKey().KeyChar;

                 Console.WriteLine("Enter user id");
                 id = Int32.Parse(Console.ReadLine());

             */
            Accountb acc = new Accountb();
          //  acc.Add();
            acc.Deposit();
            /*switch (Case)
            {

                case 'a'

                  acc.Add();
                    break;
        }
        */

                // acc.Add();


                /*

                switch (Case)
                {

                    case 'F':
                        id = Int32.Parse(Console.ReadLine());
                        int branch = Int32.Parse(Console.ReadLine());
                        string accholder = Console.ReadLine();
                        string str = Console.ReadLine();
                        double bal = Convert.ToDouble(str);
                        Account account = new Account(id, branch, accholder, bal);
                        user.Add(account);
                        Console.WriteLine("hello");
                        break;
                    case 'A':

                        user.AccDetails(id);
                        break;

                    case 'W':
                        Console.WriteLine("Enter the amount to be withdrawn");
                        amount = Int32.Parse(Console.ReadLine());
                        user.WithrawMoney(id, amount);
                        break;

                    case 'S':

                        Account acc = user.SearchAccount(id);
                        if (acc != null)
                            Console.WriteLine("User found");
                        else
                            Console.WriteLine("User NOT found");

                        break;

                    case 'D':

                        Console.WriteLine("Enter the amount to be Deposit");
                        amount = Int32.Parse(Console.ReadLine());
                        user.DepositAmount(id, amount);
                        break;

                    case 'C':

                        Console.WriteLine("Enter the time for which interest to be calculated");
                        user.CalculateInterest(id);
                        break;


                }
            }
            Console.ReadLine();


        }

    */

            }
        }
}



