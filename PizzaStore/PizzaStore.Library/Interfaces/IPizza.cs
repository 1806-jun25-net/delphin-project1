using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Interfaces
{
    public interface IPizza
    {
        string PizzaSize { get; set; } // large or medium or small
        string PizzaToppings(List<string> toppings); // pepperoni or sausage or cheese or etc...
        string PizzaCrustType { get; set; } // Thin or Thick
        string PizzaSauceType { get; set; } // Marinara, white sauce, etc...

    }
}
