using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountDetails;


    namespace AccountHolders
    {

  
    class User //created a user 
        {
        public List<Account> users = new List<Account>();
        /*
            List<Account> users = new List<Account>() {

                    new Account(0,0,"palvi",1000),

                    new Account(1,1,"priya",10),

                    new Account(2,2,"nishu",1000),


                    new Account(3,0,"aina",1000),
            };
            */

        public Account SearchAccount(int id)
            {
                Account userSearched = new Account();
                userSearched = null;
                for (int i = 0; i < users.Count; i++)
                {

                    if (id == users[i].getAccId())
                    {
                    Console.WriteLine("hello");
                        userSearched = users[i];
                    }

                }
                return userSearched;
            }

        public void Add(Account t)
        {
            users.Add(t);
            for(int i = 0; i < users.Count; i++)
            {
                Console.WriteLine("{0}",users[i].getAccBranch());
            }

        }

            public void AccDetails(int id)
            {
                Account userAccount = SearchAccount(id);
                Console.WriteLine("Account Holder is" + userAccount.getAccHolder());
                Console.WriteLine("Account Type is" + userAccount.getAccBranch());
                Console.WriteLine("Account Id is" + userAccount.getAccId());
                Console.WriteLine("Balance Amount is" + userAccount.getBalAmount());


            }


            public void deductAmount(double bal, double amountWithdraw,Account account)
            { //DEDUCT AMOUNT

                bal = account.getBalAmount() - amountWithdraw;
                account.setBalAmount(bal);
                Console.WriteLine("Succesfully withdrawn money");

            }


            public void WithrawMoney(int id, double amountWithdraw)

            {
                Account account = SearchAccount(id);
                int minBalance = 0;
                int flag = 0;
                double bal = account.getBalAmount();
                if (account.getAccBranch() == 0)
                {
                    minBalance = 1000;
                    if (bal >= minBalance && amountWithdraw < bal)
                    {
                        Console.WriteLine("Saving Account");
                        deductAmount(bal, amountWithdraw,account);
                        flag = 1;

                    }

                }

                else if (account.getAccBranch() == 1)
                {

                    if (amountWithdraw < bal)
                    {

                        Console.WriteLine("Current Account");
                        deductAmount(bal, amountWithdraw,account);
                        flag = 1;

                    }

                }
                else
                {

                    Console.WriteLine("DMAT Account");
                    double bala = account.getBalAmount() - amountWithdraw;
                    if (bala > -10000)
                    {

                        deductAmount(bal, amountWithdraw,account);
                        flag = 1;
                    }

                }
                if (flag == 0)
                {
                    Console.WriteLine("Cannot withdraw money");
                }


                Console.WriteLine("Now balance is {0}", account.getBalAmount());

            }

            public void DepositAmount(int id, double depositamount)

            {

                Account account = SearchAccount(id);
                account.setBalAmount(account.getBalAmount() + depositamount);
                Console.WriteLine("Current balance is {0}", account.getBalAmount());

            }



            public void CalculateInterest(int id)

            {
                
                Account account = SearchAccount(id);
                double bal = account.getBalAmount();
                int branch = account.getAccBranch();
                if (branch == 0)
                {
                
                    bal = bal + (bal * (0.04)) / 100;


                }
                else if (branch == 1)
                {
                
                    bal = bal + (bal * 0.01) / 100;

                }
                else
                {
                    Console.WriteLine("Cannot calculate interest on DMAT account");

                }
                account.setBalAmount(bal);

                Console.WriteLine("Now the balance ammount is {0}", account.getBalAmount());

            }

        }

    }




