using System;
namespace PizzaStoreMini
{
	public class DNPepperoniPizza : Pizza
	{
		public DNPepperoniPizza()
		{
            name = "DN The best pepperoni pizza";
            dough = "DN Very thin + 1 dough";
            sauce = "DN Very spicy + 1 sauce";
            toppings.Add("DN Tomato + 1");
            toppings.Add("DN Cheese + 2");
        }
	}
}

