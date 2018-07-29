using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Accounts
    {
        public int _accountId;
        public int _accountBranch;
        public string _accountHolder;
        public int _balanceAmount;

        public Accounts()
        {

        }

        public Accounts(int _accountId, int _accountBranch, string _accountHolder, int _balanceAmount)
        {
            this._accountBranch = _accountBranch;
            this._accountId = _accountId;
            this._accountHolder = _accountHolder;
            this._balanceAmount = _balanceAmount;
        }
    }
}
