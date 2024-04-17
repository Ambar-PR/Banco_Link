using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    //Heredar e la clase Account
    internal class SavingsAccount : Account
    {
        private decimal tasaDeInteres;

        // Constructor para inicializar una cuenta de ahorros con saldo inicial y tasa de interés
        public SavingsAccount(decimal initialBalance, decimal interestRate) : base(initialBalance)
        {
            this.tasaDeInteres = interestRate;
        }

        // Método para calcular los intereses generados por la cuenta de ahorros
        public decimal CalcularInteres()
        {
            decimal intereses = Balance * tasaDeInteres;
            return intereses;
        }

        // Método para añadir los intereses generados al saldo de la cuenta de ahorros
        public void AgregarInteres()
        {
            decimal interes = CalcularInteres();
            Credit(interes);
        }
    }
}
