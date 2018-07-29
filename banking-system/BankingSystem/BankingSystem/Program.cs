using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using database;
using BusinessLogic;


namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Data d = new Data();
            d.Connect();
            int f = 1;
           
            int flag;
            while (f == 1)
            {
                Console.WriteLine("Press '1' to continue");
                flag= Int32.Parse(Console.ReadLine());
                if (flag==0)
                {
                    f = 0;
                    break;
                }
                Console.WriteLine("Press '1' if you want to see Add \n Press '2' if you want to deposit mooney\n  Press '3' if you want to withdraw money \n 0Press '4' if you want to calculate interest \n Press 5 to  searchdetails \n Press 6 to display accdetails");
                    
                Console.WriteLine("Enter operation you want to perform");
                int ch;
                ch= Int32.Parse(Console.ReadLine());
                Accountb acc = new Accountb();
        
                switch (ch)
                {

                    case 1:

                        acc.Add();
                        break;

                    case 2:
                        acc.Deposit();
                        break;

                    case 3:
                        acc.Withdraw();
                        break;

                    case 4:
                        acc.CalculateInterest();
                        break;
                    case 5:

                    int t=  acc.Search();
                        if(t==-1)
                        Console.WriteLine("user dont exists");
                        else
                        Console.WriteLine("user exists");
                        break;

                    case 6:

                        acc.Display();
                        break;


                }

                Console.ReadLine();

              }

        }   
    }
}



