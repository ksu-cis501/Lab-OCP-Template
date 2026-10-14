using System;
using System.Threading;

namespace OrderNaive
{
    /// <summary>
    /// Represents a customer order and knows how to process its payment.
    /// </summary>
    public class Order
    {
        private double _amount;

        /// <summary>
        /// Unique identifier of the order.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of the item being ordered.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Total amount of the order. Negative values are ignored.
        /// </summary>
        public double Amount
        {
            get { return _amount; }
            set
            {
                if (value >= 0)
                {
                    _amount = value;
                }
            }
        }

        /// <summary>
        /// True once the payment has been accepted.
        /// </summary>
        public bool Paid { get; private set; } = false;

        /// <summary>
        /// Creates a new, unpaid order.
        /// </summary>
        /// <param name="id">Unique identifier of the order.</param>
        /// <param name="name">Name of the item being ordered.</param>
        /// <param name="amount">Total amount of the order.</param>
        public Order(int id, string name, double amount)
        {
            ID = id;
            Name = name;
            Amount = amount;
        }

        /// <summary>
        /// Processes the payment for this order using the selected payment method.
        /// </summary>
        /// <param name="method">
        /// An integer that represents the payment method:
        /// 1 = Cash, 2 = Credit Card.
        /// </param>
        public void ProcessOrder(int method)
        {
            // Step 1: Get funds from the selected payment method.
            switch (method)
            {
                case 1:
                    Console.WriteLine("Processing payment with Cash...");
                    break;

                case 2:
                    Console.WriteLine("Processing payment with Credit Card...");
                    break;

                default:
                    Console.WriteLine("Payment method not accepted.");
                    return; // Unknown method: the order stays unpaid.
            }

            // Step 2: Simulate the time it takes to complete the payment.
            Thread.Sleep(1000);

            // Step 3: Mark the order as paid.
            // (For simplicity, we assume the payment method always has enough funds.)
            Paid = true;
        }
    }
}
