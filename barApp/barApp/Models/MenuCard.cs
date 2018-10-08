using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barApp.ViewModels
{
    class MenuCard
    {
        private List<Drink> _drinks;

        public MenuCard()
        {
            _drinks = new List<Drink>();
        }

        public void AddDrink(Drink drink)
        {
            _drinks.Add(drink);
        }

        public void AddDrink(string name, List<string> ingredients)
        {
            Drink drink = new Drink(name, ingredients);
        }

        public void AddDrink(string name, string ingredient1, string ingredient2)
        {
            List<string> ingredients = new List<string>();
            ingredients.Add(ingredient1);
            ingredients.Add(ingredient2);
            Drink drink = new Drink(name, ingredients);
        }

        public List<Drink> GetDrinksList()
        {
            return _drinks;
        }
    }
}
