using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global
{
    public static class Globals
    {
        public static barApp.Models.MenuCard barMenuCard;

        static Globals()
        {
            barMenuCard = new barApp.Models.MenuCard();
        }
    }
}

