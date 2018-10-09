using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barApp.ViewModels
{
    class MenuCard
    {
		// Opretter liste med drinks
		public List<Drink> MC_drinks;

		// Evt lav en get-drink funktion???
		/***************/

		// Opretter menu kort.
		public MenuCard()
        {
            MC_drinks = new List<Drink>();
        }

		// Tilføjer til menukort
        public void AddDrink(Drink drink)
        {
            MC_drinks.Add(drink);
        }
		// Overload 1
        public void AddDrink(string name, List<string> ingredients)
        {
            Drink tmp_drink = new Drink(name, ingredients);
			MC_drinks.Add(tmp_drink);
		}
		// Overload 2
		public void AddDrink(string name, string ingredient1, string ingredient2)
        {
            List<string> ingredients = new List<string>();
            ingredients.Add(ingredient1);
            ingredients.Add(ingredient2);
            Drink tmp_drink = new Drink(name, ingredients);
			MC_drinks.Add(tmp_drink);
		}
    }
}
