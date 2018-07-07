using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
    public class Ingredient
    {
        public string IngredientName { get; set; }
        public int IngredientQuantity { get; set; }
        public List<KeyValuePair<string, int>> IngredientInventory;

        public override string ToString()
        {
            return "Quantity:  " + IngredientQuantity + " " + IngredientName;
        }

        public List<KeyValuePair<string, int>> AddIngredient(string ingredient, int quantity)
        {
            if(ingredient == null)
            {
                Console.WriteLine("You did not enter any ingredients to add to inventory");
            }

            if(ingredient != null)
            {
                foreach (var key in IngredientInventory)
                {
                    if (ingredient.Equals(key))
                    {
                        IngredientQuantity = IngredientQuantity + quantity;
                    }
                }
                IngredientInventory.Add(new KeyValuePair<string, int>(ingredient, quantity));
            }
            
        }
    }
}
