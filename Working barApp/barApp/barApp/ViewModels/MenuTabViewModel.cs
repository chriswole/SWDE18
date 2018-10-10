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
        public string NameDrink1
        {
            get
            {
                if (Global.Globals.barMenuCard._drinks.Count() > 0)
                    return Global.Globals.barMenuCard._drinks[0]._name;
                else
                    return "";
            }
        }

        public string FirstIngredientDrink1
        {
            get
            {
                if (Global.Globals.barMenuCard._drinks.Count() > 0)
                    return Global.Globals.barMenuCard._drinks[0]._ingredients[0];
                else
                    return "";
            }
        }

        public string SecondIngredientDrink1
        {
            get
            {
                if (Global.Globals.barMenuCard._drinks.Count() > 0)
                    return Global.Globals.barMenuCard._drinks[0]._ingredients[1];
                else
                    return "";
            }
        }

        public string NameDrink2
        {
            get
            {
                if (Global.Globals.barMenuCard._drinks.Count() > 1)
                    return Global.Globals.barMenuCard._drinks[1]._name;
                else
                    return "";
            }
        }

        public string FirstIngredientDrink2
        {
            get
            {
                if (Global.Globals.barMenuCard._drinks.Count() > 1)
                    return Global.Globals.barMenuCard._drinks[1]._ingredients[0];
                else
                    return "";
            }
        }

        public string SecondIngredientDrink2
        {
            get
            {
                if (Global.Globals.barMenuCard._drinks.Count() > 1)
                    return Global.Globals.barMenuCard._drinks[1]._ingredients[1];
                else
                    return "";
            }
        }

        public string NameDrink3
        {
            get
            {
                if (Global.Globals.barMenuCard._drinks.Count() > 2)
                    return Global.Globals.barMenuCard._drinks[2]._name;
                else
                    return "";
            }
        }

        public string FirstIngredientDrink3
        {
            get
            {
                if (Global.Globals.barMenuCard._drinks.Count() > 2)
                    return Global.Globals.barMenuCard._drinks[2]._ingredients[0];
                else
                    return "";
            }
        }

        public string SecondIngredientDrink3
        {
            get
            {
                if (Global.Globals.barMenuCard._drinks.Count() > 2)
                    return Global.Globals.barMenuCard._drinks[2]._ingredients[1];
                else
                    return "";
            }
        }

	    public string NameDrink4
	    {
	        get
	        {
	            if (Global.Globals.barMenuCard._drinks.Count() > 3)
	                return Global.Globals.barMenuCard._drinks[2]._name;
	            else
	                return "";
	        }
	    }

	    public string FirstIngredientDrink4
	    {
	        get
	        {
	            if (Global.Globals.barMenuCard._drinks.Count() > 3)
	                return Global.Globals.barMenuCard._drinks[2]._ingredients[0];
	            else
	                return "";
	        }
	    }

	    public string SecondIngredientDrink4
	    {
	        get
	        {
	            if (Global.Globals.barMenuCard._drinks.Count() > 3)
	                return Global.Globals.barMenuCard._drinks[2]._ingredients[1];
	            else
	                return "";
	        }
	    }

	    public string NameDrink5
	    {
	        get
	        {
	            if (Global.Globals.barMenuCard._drinks.Count() > 4)
	                return Global.Globals.barMenuCard._drinks[2]._name;
	            else
	                return "";
	        }
	    }

	    public string FirstIngredientDrink5
	    {
	        get
	        {
	            if (Global.Globals.barMenuCard._drinks.Count() > 4)
	                return Global.Globals.barMenuCard._drinks[2]._ingredients[0];
	            else
	                return "";
	        }
	    }

	    public string SecondIngredientDrink5
	    {
	        get
	        {
	            if (Global.Globals.barMenuCard._drinks.Count() > 4)
	                return Global.Globals.barMenuCard._drinks[2]._ingredients[1];
	            else
	                return "";
	        }
	    }
    }
}
