using System;
using System.Collections.Generic;
using System.Text;

namespace Einstein
{


    public enum MenuType
    {
        System,
        CardInfo,
        BasicInfo,
        Door,
        Report,
        Setting,
        Help
    }

    public class Menu
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public MenuType MenuType { get; set; }
    }

    public class TestMenu
    {
        public static IList<Menu> GetTestMenu()
        {
            IList<Menu> list = new List<Menu>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(
                    new Menu()
                    {
                        Name = "Menu" + i.ToString(),
                        ID=System.Guid.NewGuid().ToString(),
                        MenuType = MenuType.Door
                    }
                    );
            }
            return list;
        }
    }
}
