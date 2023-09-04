using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities {
    class BussinesAccount : Account { // colocando os : eu estou falando que a bussinesaccount (subclasse) vai ter tudo que a account (superclasse) tem

        public double LoanLimit { get; set; }

        public BussinesAccount() {
        }

        public BussinesAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) { // chamo o contrutrutor da superclasse account com a palavra base com essas atribuições e depois só coloco as coisas novas do contrutor da subclasse
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) {
            if (amount <= LoanLimit) {
                Balance = Balance + amount;
            }
        }
    }
}
