using System;
using System.Xml.Linq;

namespace PizzaStoreMini
{
	public class DNGreekPizza : Pizza
	{
		public DNGreekPizza()
		{
            name = "DN The best greek pizza";
            dough = "DN Very thin + 2 dough";
            sauce = "DN Very spicy + 2 sauce";
            toppings.Add("DN Banana + 1");
            toppings.Add("DN Potato + 2");
        }
	}
}

