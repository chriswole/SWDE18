using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barApp.Models
{
    public class Drink
    {
		public string _name {get; set; }
		public List<string> _ingredients;

		public Drink()
		{
			_ingredients = new List<string>();
            _ingredients.Add("");
            _ingredients.Add("");
        }

		public Drink(string name, List<string> ingredients)
		{
			_ingredients = new List<string>();
			_name = name;
            _ingredients = ingredients;
        }

        public string GetName()
        {
            return _name;
        }

        public List<string> GetIngredients()
        {
            return _ingredients;
        }

		public void SetFirstIngredient(string name)
		{
			_ingredients[0] = name;
		}
		public void SetSecondIngredient(string name)
		{
			_ingredients[1] = name;
		}
		public string GetFirstIngredient()
		{
			return _ingredients[0];
		}
		public string GetSecondIngredient()
		{
			return _ingredients[1];
		}
	}
}
