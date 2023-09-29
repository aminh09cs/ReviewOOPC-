
using PizzaStoreMini;
using PizzaStoreMini.Store;
using System.Collections.Generic;

namespace PizzaStoreMini
{
    class Program
    {
        static void Main(string[] args)
        {

            PizzaStore pizzaStore;

            pizzaStore = new HUEPizzaStore();
            pizzaStore.OrderPizza("cheese");

            pizzaStore = new DNPizzaStore();
            pizzaStore.OrderPizza("greek");

        }
    }
}
