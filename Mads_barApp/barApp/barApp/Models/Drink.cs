using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barApp.ViewModels
{
    public class Drink
    {
		public string D_Name {get; set; }
		public List<string> D_Ingredients { get; set; }

	
		public Drink(string name, List<string> ingredients)
		{
			D_Name = name;
			D_Ingredients = ingredients;
        }
	}
}
