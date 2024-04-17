using Banco;

namespace Banco
{
    /*
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine("Choose an account to test:");
            Console.WriteLine("1. Savings Account");
            Console.WriteLine("2. Checking Account");
            Console.Write("Enter your choice (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                // Crear una cuenta de ahorros
                SavingsAccount savingsAccount = new SavingsAccount(1000, 0.05m); // Saldo inicial de 1000 y tasa de interés del 5%

                // Solicitar y procesar depósitos y retiros en la cuenta de ahorros
                Console.WriteLine("Savings Account Balance: " + savingsAccount.Balance);
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.Write("Enter your choice (1 or 2): ");
                int actionChoice = Convert.ToInt32(Console.ReadLine());

                if (actionChoice == 1)
                {
                    Console.Write("Enter the amount to deposit: ");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    savingsAccount.Credit(depositAmount);
                    Console.WriteLine("Updated Savings Account Balance: " + savingsAccount.Balance);
                }
                else if (actionChoice == 2)
                {
                    Console.Write("Enter the amount to withdraw: ");
                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                    savingsAccount.Debit(withdrawAmount);
                    Console.WriteLine("Updated Savings Account Balance: " + savingsAccount.Balance);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                }
            }
            else if (choice == 2)
            {
                // Crear una cuenta de cheques
                CheckAccount checkingAccount = new CheckAccount(500, 1.5m); // Saldo inicial de 500 y tarifa por transacción de 1.5

                // Solicitar y procesar depósitos y retiros en la cuenta de cheques
                Console.WriteLine("Checking Account Balance: " + checkingAccount.Balance);
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.Write("Enter your choice (1 or 2): ");
                int actionChoice = Convert.ToInt32(Console.ReadLine());

                if (actionChoice == 1)
                {
                    Console.Write("Enter the amount to deposit: ");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    checkingAccount.Credit(depositAmount);
                    Console.WriteLine("Updated Checking Account Balance: " + checkingAccount.Balance);
                }
                else if (actionChoice == 2)
                {
                    Console.Write("Enter the amount to withdraw: ");
                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                    checkingAccount.Debit(withdrawAmount);
                    Console.WriteLine("Updated Checking Account Balance: " + checkingAccount.Balance);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }
        }
    }
}

*/

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ejercicio - Jerarquía de Herencia de Cuentas");

            bool Salir = false;

            // Bucle principal que permite al usuario interactuar con el programa
            while (!Salir)
            {
                Console.WriteLine("\nElige una acción:");
                Console.WriteLine("1. Savings Account");
                Console.WriteLine("2. Checking Account");
                Console.WriteLine("3. Exit");
                Console.Write("\nEnter your choice (1, 2, or 3): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                // Menú de opciones para el usuario
                switch (choice)
                {
                    case 1:
                        CuentaDeAhorros();
                        break;
                    case 2:
                        CuentaDeCheques();
                        break;
                    case 3:
                        Salir = true;
                        Console.WriteLine("Saliendo de la aplicación...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, ingresa 1, 2 o 3.");
                        break;
                }
            }
        }

        // Método para interactuar con una cuenta de ahorros
        static void CuentaDeAhorros()
        {
            // Crear una cuenta de ahorros
            SavingsAccount savingsAccount = new SavingsAccount(1000, 0.05m); // Saldo inicial de $1000 y tasa de interés del 5%

            Console.Clear();

            // Solicitar y procesar depósitos y retiros en la cuenta de ahorros
            Console.WriteLine("\nSaldo de la Cuenta de Ahorros: " + savingsAccount.Balance);
            Console.WriteLine("¿Qué desea hacer? \n1. Depositar \n2. Retirar");
            Console.Write("\nIngrese su elección (1 o 2): ");
            int actionChoice = Convert.ToInt32(Console.ReadLine());

            // Realizar un depósito en la cuenta de ahorros
            if (actionChoice == 1)
            {
                Console.Write("Ingrese la cantidad a ");
                Console.ForegroundColor = ConsoleColor.Green; // Cambiar el color a verde
                Console.Write("depositar: ");
                Console.ResetColor(); // Restablecer el color a predeterminado
                decimal depositAmountSavings = Convert.ToDecimal(Console.ReadLine());
                savingsAccount.Credit(depositAmountSavings);
                Console.WriteLine("Saldo de la Cuenta de Ahorros Actualizado: " + savingsAccount.Balance);
            }

            // Realizar un retiro de la cuenta de ahorros
            else if (actionChoice == 2)
            {
                Console.Write("Ingrese la cantidad a ");
                Console.ForegroundColor = ConsoleColor.Red; // Cambiar el color a rojo
                Console.Write("retirar: ");
                Console.ResetColor(); // Restablecer el color a predeterminado
                decimal withdrawAmountSavings = Convert.ToDecimal(Console.ReadLine());
                savingsAccount.Debit(withdrawAmountSavings);
                Console.WriteLine("Saldo de la Cuenta de Ahorros Actualizado: " + savingsAccount.Balance);
            }

            else
            {
                Console.WriteLine("Opción no válida. Por favor, ingrese 1 o 2.");
            }
        }


        // Método para interactuar con una cuenta de cheques
        static void CuentaDeCheques()
        {
            // Crear una cuenta de cheques
            CheckAccount checkingAccount = new CheckAccount(1000, 1.5m); // Saldo inicial de $1000 y tarifa por transacción de $1.5

            Console.Clear();

            // Solicitar y procesar depósitos y retiros en la cuenta de cheques
            Console.WriteLine("\nSaldo de la Cuenta de Cheques: " + checkingAccount.Balance);
            Console.WriteLine("¿Qué desea hacer? \n1. Depositar \n2. Retirar");
            Console.Write("\nIngrese su elección (1 o 2): ");
            int actionChoice = Convert.ToInt32(Console.ReadLine());

            // Realizar un depósito en la cuenta de cheques
            if (actionChoice == 1)
            {
                Console.Write("Ingrese la cantidad a ");
                Console.ForegroundColor = ConsoleColor.Green; // Cambiar el color a verde
                Console.Write("depositar: ");
                Console.ResetColor(); // Restablecer el color a predeterminado
                decimal depositAmountChecking = Convert.ToDecimal(Console.ReadLine());
                checkingAccount.Credit(depositAmountChecking);
                Console.WriteLine("Saldo de la Cuenta de Cheques Actualizado: " + checkingAccount.Balance);
            }

            // Realizar un retiro de la cuenta de cheques
            else if (actionChoice == 2)
            {
                Console.Write("Ingrese la cantidad a ");
                Console.ForegroundColor = ConsoleColor.Red; // Cambiar el color a rojo
                Console.Write("retirar: ");
                Console.ResetColor(); // Restablecer el color a predeterminado
                decimal withdrawAmountChecking = Convert.ToDecimal(Console.ReadLine());
                checkingAccount.Debit(withdrawAmountChecking);
                Console.WriteLine("Saldo de la Cuenta de Cheques Actualizado: " + checkingAccount.Balance);
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor, ingrese 1 o 2.");
            }
        }
    }
}


