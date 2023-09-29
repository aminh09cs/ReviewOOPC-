using System;
using System.Xml.Linq;

namespace PizzaStoreMini
{
	public class HUEGreekPizza : Pizza
	{
		public HUEGreekPizza()
		{
            name = "HUE The best greek pizza";
            dough = "HUE Very thin + 2 dough";
            sauce = "HUE Very spicy + 2 sauce";
            toppings.Add("HUE Banana + 1");
            toppings.Add("HUE Potato + 2");
        }
	}
}

