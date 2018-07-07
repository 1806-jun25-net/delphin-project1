using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models
{
    public class Order : IOrder
    {

        private DateTime orderDateTime;
        public User orderUserID;
        private string orderLocation;
        private decimal orderTotalPrice;


        public DateTime OrderDateTime
        {
            get => orderDateTime;

            set
            {
                try
                {
                    orderDateTime = DateTime.Now;
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    throw new Exception("Unable to get current time.");
                }
            }
        }

        public string OrderLocation
        {
            get => orderLocation;
            set
            {
                // "value" is the value passed to the setter.
                if (value.Length == 0)
                {
                    // good practice to provide useful messages when throwing exceptions,
                    // as well as the name of the relevant parameter if applicable.
                    throw new ArgumentException("Location must not be empty.", nameof(value));
                }

                orderLocation = value;
            }

        }

        public string OrderUserID { get; set; }

        public decimal OrderTotalPrice { get; set; }
    }
}
