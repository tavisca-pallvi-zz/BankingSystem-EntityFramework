using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using database;
using BusinessLogic;



namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountdbEntities1 entity = new AccountdbEntities1();



            // Create and save a new Blog 

            int ch;
            Accountentity acc = new Accountentity();

            Console.Write("Which framework want to choose enter 0 for entity and 1 for ado.net");
            int op = Int32.Parse(Console.ReadLine());
            Accountb ac;
           
            switch (op)
            {


                case 0:

                    int f1 = 1;

                    int flag1;
                    while (f1 == 1)
                    {
                        Console.WriteLine("Press '1' to continue");
                        flag1 = Int32.Parse(Console.ReadLine());
                        if (flag1 == 0)
                        {
                            f1 = 0;
                            break;
                        }
                        Console.Write("Which operation to performance");
                        Console.WriteLine("Press '1' if you want to see Add \n Press '2' if you want to deposit mooney\n  Press '3' if you want to withdraw money \n 0Press '4' to search \n Press 5 to  to display accdetails \n press 6 to calculate interest");

                 

                        ch = Int32.Parse(Console.ReadLine());
                        switch (ch)
                        {

                            case 1:
                                acc.Insert();

                                break;


                            case 2:
                                acc.Deposit();
                                break;


                            case 3:
                                acc.Withdraw();
                                break;



                            case 4:

                                acc.Search();
                                break;
                            case 5:
                                acc.Display();
                                break;
                            case 6:
                                acc.CalculateInterest();
                                break;
                        }
                       
                    }
                    break;
                case 1:

                    int f = 1;
                    Data d = new Data();
                    d.Connect();

                    int flag;
                    while (f == 1)
                    {
                        Console.WriteLine("Press '1' to continue");
                        flag = Int32.Parse(Console.ReadLine());
                        if (flag == 0)
                        {
                            f = 0;
                            break;
                        }
                        Console.WriteLine("Press '1' if you want to see Add \n Press '2' if you want to deposit mooney\n  Press '3' if you want to withdraw money \n 0Press '4' if you want to calculate interest \n Press 5 to  searchdetails \n Press 6 to display accdetails");

                        Console.WriteLine("Enter operation you want to perform");

                        ch = Int32.Parse(Console.ReadLine());
                        ac = new Accountb();

                        switch (ch)
                        {

                            case 1:

                                ac.Add();
                                break;

                            case 2:
                                ac.Deposit();
                                break;

                            case 3:
                                ac.Withdraw();
                                break;

                            case 4:
                                ac.CalculateInterest();
                                break;
                            case 5:

                                int t = ac.Search();
                                if (t == -1)
                                    Console.WriteLine("user dont exists");
                                else
                                    Console.WriteLine("user exists");
                                break;

                            case 6:

                                acc.Display();
                                break;


                        }

                    }
                    break;

            }
            Console.ReadLine();

        }
    }
}




