using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Interfaces
{
    public interface ILocation
    {
        string LocationName { get; set; }
        List<int> LocationInventory(List<string> ingredients);
        //List<string> Ingredients(List<string> ingredients);
        List<DateTime> OrderHistory(DateTime orderDateTime);
    }
}
