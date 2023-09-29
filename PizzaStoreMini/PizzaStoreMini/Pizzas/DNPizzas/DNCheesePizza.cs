using System;
namespace PizzaStoreMini
{
	public class DNCheesePizza :Pizza
	{
		public DNCheesePizza()
		{
			name = "DN The best cheese pizza";
			dough = "DN Very thin dough";
			sauce = "DN Very spicy sauce";
			toppings.Add("DN Black olives");
            toppings.Add("DN Cheese");

        }
    }
}

