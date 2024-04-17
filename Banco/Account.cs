using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Account
    {
       private decimal balance;

        public decimal Balance
        {
            get { return balance; }
        }

        // Constructor para inicializar una cuenta con un saldo inicial
        public Account(decimal initialBalance)
        {
            if (initialBalance >= 0.0m)
            {
                balance = initialBalance;
            }
            else
            {
                throw new ArgumentException("El saldo inicial debe ser mayor o igual a 0,0");
            }
        }

        // Método para acreditar una cantidad al saldo de la cuenta
        public void Credit(decimal amount)
        {
            balance += amount;
        }

        // Método para debitar una cantidad del saldo de la cuenta
        // Retorna true si la transacción se realizó con éxito, false de lo contrario
        public bool Debit(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("El monto del débito excede el saldo de la cuenta.");
                return false;
            }
        }
    }
}
