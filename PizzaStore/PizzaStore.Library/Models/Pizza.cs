using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models
{
    public class Pizza : IPizza
    {
        public string PizzaSize
        {
            // could have a prompt for user-input
            // with a switch case for less mistake from user input
            // 1 for large, 2 for medium, and 3 for small
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public string PizzaCrustType
        {
            // could have a prompt for user-input
            // with a switch case for less mistake from user input
            // 1 for thickCrust, or 2 for ThinCrust
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }


        public string PizzaSauceType
        {
            // could have a prompt for user-input
            // with a switch case for less mistake from user input
            // 1 for DefaultMarinaraSauce, or 2 for WhiteSauce/AnyOtherTypeOfSauce
            // as an example
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public string PizzaToppings(List<string> toppings)
        {
            // could have a prompt for user-input
            // with a switch case for less mistake from user input
            // 1 for Pepperoni, 2 for sausage, 3 for beef (example)
            throw new NotImplementedException();
        }
    }
}
