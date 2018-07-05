using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models
{
    public class Location : ILocation
    {
        private string locationName;
        public string LocationName
        {
            get => locationName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Name must not be empty.", nameof(value));
                }
                locationName = value;
            }
        }


        public List<int> LocationInventory(List<string> ingredients)
        {
            throw new NotImplementedException();
        }

        public List<DateTime> OrderHistory(DateTime orderDateTime)
        {
            throw new NotImplementedException();
        }

        public AddIngredients(int )
    }
}
