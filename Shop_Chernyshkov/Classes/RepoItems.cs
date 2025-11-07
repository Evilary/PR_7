using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Chernyshkov.Classes
{
    public class RepoItems
    {
        public static List<object> AllItems()
        {
            List<object> AllItems = new List<object>();

            AllItems.Add(new Children("Игрушка интерактивная", 2200, 3));
            AllItems.Add(new Children("Кактус танцующий", 894, 6));
            AllItems.Add(new Children("Мягкая игрушка кошка подушка", 1754, 6));
            AllItems.Add(new Sport("Спортивный мужской костюм", 4913, "S"));
            AllItems.Add(new Sport("Мяч для водного поло", 812, "61-63 см"));
            AllItems.Add(new Sport("Набор для гольфа Partida", 2200, "600*800 мм"));

            return AllItems;
        }

    }
}
