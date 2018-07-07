using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Interfaces
{
    public interface ILocation
    {
        string LocationName { get; set; }
        string LocationID { get; set; }
        List<KeyValuePair<string, int>> LocationInventory(); // ingredientsName and number
        //List<KeyValuePair<string, int>> AddInventory();
        List<KeyValuePair<string, DateTime>> OrderHistory(); // UserID and DateTime
    }
}
