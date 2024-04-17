using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    //Heredar e la clase Account
    internal class CheckAccount : Account
    {
        // Tarifa por transacción de la cuenta de cheques
        private decimal tarifaTransaccion;
        

        // Constructor para inicializar una cuenta de cheques con saldo inicial y tarifa por transacción
        public CheckAccount(decimal initialBalance, decimal transactionFee) : base(initialBalance)
        {
            this.tarifaTransaccion = transactionFee;
        }


        public new void Credit(decimal amount)
        {
            base.Credit(amount - tarifaTransaccion);
        }

        // Método para debitar una cantidad de la cuenta de cheques, restando la tarifa de transacción si la transacción es exitosa
        public new bool Debit(decimal amount)
        {
            bool success = base.Debit(amount);
            if (success)
            {
                base.Debit(tarifaTransaccion);
            }
            return success;
        }
    }
}
