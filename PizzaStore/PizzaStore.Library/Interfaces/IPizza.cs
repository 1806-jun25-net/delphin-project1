using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Interfaces
{
    public interface IPizza
    {
        string Size { get; set; } // large or medium or small
        string Toppings(List<string> toppings); // pepperoni or sausage or cheese or etc...
        string CrustType { get; set; } // Thin or Thick
        string SauceType { get; set; } // Marinara, white sauce, etc...

    }
}
