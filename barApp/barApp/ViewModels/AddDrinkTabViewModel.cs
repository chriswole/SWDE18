using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barApp.ViewModels
{
	class AddDrinkTabViewModel
		:Screen
	{

		//public MenuCard menuCard = new MenuCard();
		public Drink drink = new Drink();

		public string Name
		{
			get => drink._name;
			set
			{
				if (Name != drink._name)
				{
					drink._name = value;
					NotifyOfPropertyChange(() => Name);
				}
			}
		}

		public string firstIngredient
		{
			get => drink.GetFirstIngredient();
			set
			{
				if (firstIngredient != drink.GetFirstIngredient())
				{
					drink.SetFirstIngredient(value);
					NotifyOfPropertyChange(() => firstIngredient);
				}
			}
		}

		public string secondIngredient
		{
			get => drink.GetSecondIngredient();
			set
			{
				if (secondIngredient != drink.GetSecondIngredient())
				{
					drink.SetSecondIngredient(value);
					NotifyOfPropertyChange(() => secondIngredient);
				}
			}
		}


		public void AddDrink()
		{
			menuCard.AddDrink(drink);
		}
	}
}