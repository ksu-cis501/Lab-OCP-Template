using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderNaive
{
    class Order
    {
        private int _id;
        private double _amount;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name;

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
        public bool Paid { get; set; } = false;
            
        public Order(int id, String name, double amount)
        {
            ID = id;
            Name = name;
            Amount = amount;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="method">An integer that represents the way of payment</param>
        public void ProcessOrder(int method)
        {
            // 1- Get funds from payment method
            switch(method)
            {
                case 1:
                    Console.WriteLine("Processing payment with Cash");
                    break;
                case 2:
                    Console.WriteLine("Processing payment with Credit Card");
                    break;
                default:
                    Console.WriteLine("Payment Method Not Accepted");
                    break;
            }

            // 2 - If enough funds, mark order as paid-We assume there are-
            Paid = true;
            Thread.Sleep(1000);
        }

    }
}
