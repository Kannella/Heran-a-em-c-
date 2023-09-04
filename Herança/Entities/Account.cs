using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities {
    class Account {

        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // private set -> é permitido em outra classe acessar -> double x = Balance ; entretanto não é permitido fazer isso -> Balance = 10 pois eu não posso alterar, somente acessar.
        // protected set -> o valor pode ser alterado dentro da propria classe ou por alguma subclasse
        public Account() {

        }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount) {
            Balance = Balance - amount;
        }

        public void Deposit(double amount) {
            Balance = Balance + amount;
        }
    }
}
