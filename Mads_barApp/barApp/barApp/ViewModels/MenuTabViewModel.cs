using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barApp.ViewModels
{
	class MenuTabViewModel
		:Screen
	{
		// parametisere menukort
		public MenuCard M_Card;

		// Henter menukortet
		public List<Drink> DrinksList => M_Card.MC_drinks;


		// Default constructor - laver tom liste (til linking)
		public MenuTabViewModel()
		{
			M_Card = new MenuCard();
		}

		// Constructor til MenuTabViewModle der linker til et MenuCard
		public MenuTabViewModel(MenuCard newCard)
		{
			M_Card = newCard;
		}

	}
}
