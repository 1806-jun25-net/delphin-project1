using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStore.Models
{
    public class IngredientsSelectionViewModel
    {
        public List<SelectIngredientsEditorViewModel> Ingredients { get; set; }
        public IngredientsSelectionViewModel()
        {
            this.Ingredients = new List<SelectIngredientsEditorViewModel>();
        }


        public IEnumerable<int> getSelectedIds()
        {
            // Return an Enumerable containing the Id's of the selected people:
            return (from p in this.Ingredients where p.Selected select p.Id).ToList();
        }
    }
}