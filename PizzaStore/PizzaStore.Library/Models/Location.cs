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



        public List<KeyValuePair<string, int> LocationInventory(List<string> ingredients)
        {
            throw new NotImplementedException();
    }

    public List<DateTime> OrderHistory(DateTime orderDateTime)
    {
        throw new NotImplementedException();
    }

    public List<T>AddIngredients(List<KeyValuePair<string, int>>)
    {

        new KeyValuePair<string, int>("Pepperoni", 1),
        new KeyValuePair<string, int>("Sausage", 2),
        new KeyValuePair<string, int>("Beef", 3),
        new KeyValuePair<string, int>("Steak", 4),
        new KeyValuePair<string, int>("Chicken", 5),
        new KeyValuePair<string, int>("Onion", 6),
        new KeyValuePair<string, int>("Green Pepper", 6),
        new KeyValuePair<string, int>("Mushroom", 6),
        new KeyValuePair<string, int>("Red Pepper", 6),



    }
}
}
