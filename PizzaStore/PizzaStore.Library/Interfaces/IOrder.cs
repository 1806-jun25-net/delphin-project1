using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Interfaces
{
    public interface IOrder
    {
       
        string OrderLocation { get; set; }
         DateTime OrderDateTime { get; set; }
        string OrderUserID { get; set; } // To be set as "UserID-OrderDateTime"
        //string OrderID { get; set; }
       
        decimal OrderPrice { get; set; }

        //string Ingredients(List<string> ingredients);



    }
}
