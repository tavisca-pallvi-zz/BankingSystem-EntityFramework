using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountHolders;

namespace AccountDetails
{
    public enum AccountType

    {
        Savings = 0,
        Current = 1,
        DMAT = 2
    }

    class Account
    {
        private int _accountId;
        private int _accountBranch;
        private string _accountHolder;
        private double _balanceAmount;


        public Account()
        {

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
}

