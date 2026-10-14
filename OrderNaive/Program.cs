using System;

namespace OrderNaive
{
    /// <summary>
    /// Console entry point: creates an order, asks the user for a payment
    /// method, and reports whether the payment was accepted.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Order anOrder = new Order(1, "Headphones", 35.99);

            Console.WriteLine("*** N A I V E ***");
            Console.WriteLine();
            Console.WriteLine($"  Order #{anOrder.ID}: {anOrder.Name} - {anOrder.Amount:C}");
            Console.WriteLine();
            Console.WriteLine("  Select Method of Payment");
            Console.WriteLine("  1- Cash");
            Console.WriteLine("  2- Credit Card");
            Console.Write("  > ");

            // Read the user's choice. Non-numeric input is treated as an
            // invalid option (0) instead of crashing the program.
            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                option = 0;
            }

            anOrder.ProcessOrder(option);

            if (anOrder.Paid)
            {
                Console.WriteLine("\nYour payment has been accepted. Order in process.");
            }
            else
            {
                Console.WriteLine("\nPayment declined.");
            }

            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}
