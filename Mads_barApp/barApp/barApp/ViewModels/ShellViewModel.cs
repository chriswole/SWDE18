using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace barApp.ViewModels
{
	class ShellViewModel
		:Conductor<object>
	{
		// opretter ViewModel Objekt (så den ikke laver et nyt hver gang!)
		public MenuTabViewModel MenuVievModel_Obj = new MenuTabViewModel();

		// Anvender samme objekt, så den husker vores tilføjede drinks
		public void LoadMenu()
		{
			ActivateItem(MenuVievModel_Obj);
		}

		// Samme skal gøres her...
		public void LoadAddDrink()
		{
			ActivateItem(new AddDrinkTabViewModel());
		}
	}
}
