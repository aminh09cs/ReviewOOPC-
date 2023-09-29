
using System;

namespace PizzaStoreMini
{
	public abstract class Pizza
	{
		protected string name;
		protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();
    

		public void Prepare()
		{
			Console.WriteLine("Preparing...." + name);
            Console.WriteLine("Tossing dough...." + dough);
            Console.WriteLine("Adding sauce...." + sauce);
            Console.WriteLine("Adding toppings....");

            toppings?.ForEach((topping) =>
            {
                Console.WriteLine("\t" + topping);
            });

        }
        public void Bake()
        {
            Console.WriteLine("Baking " + name + "in 1 hour");
        }
        public void Cut()
        {
            Console.WriteLine("Cutting " + name);
        }
        public void Box()
        {
            Console.WriteLine("Boxing " + name);
        }


    }
}

