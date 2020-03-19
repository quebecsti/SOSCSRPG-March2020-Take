using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;


namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation( 0, -1, "Home", "This is your Home", @"C:\Users\ericsaumier\source\repos\SOSCSRPG\Engine\Images\Locations\Home.png");
            newWorld.AddLocation(-1, -1, "Farmer's house","A farmer's house", @"C:\Users\ericsaumier\source\repos\SOSCSRPG\Engine\Images\Locations\farmhouse.png");
            newWorld.AddLocation(-2, -1, "Farmer's field", "A field with Corn and rats", @"C:\Users\ericsaumier\source\repos\SOSCSRPG\Engine\Images\Locations\Home.png");


            newWorld.AddLocation(-1, 0, "Trading Shop",
                "The shop of Susan, the trader.",
                @"C:\Users\ericsaumier\source\repos\SOSCSRPG\Engine\Images\Locations\Trader.png");

            newWorld.AddLocation(0, 0, "Town square",
                "You see a fountain here.",
               @"C:\Users\ericsaumier\source\repos\SOSCSRPG\Engine\Images\Locations\TownSquare.png");

            newWorld.AddLocation(1, 0, "Town Gate",
                "There is a gate here, protecting the town from giant spiders.",
               @"C:\Users\ericsaumier\source\repos\SOSCSRPG\Engine\Images\Locations\TownGate.png");

            newWorld.AddLocation(2, 0, "Spider Forest",
                "The trees in this forest are covered with spider webs.",
               @"C:\Users\ericsaumier\source\repos\SOSCSRPG\Engine\Images\Locations\SpiderForest.png");

            newWorld.AddLocation(0, 1, "Herbalist's hut",
                "You see a small hut, with plants drying from the roof.",
                @"C:\Users\ericsaumier\source\repos\SOSCSRPG\Engine\Images\Locations\HerbalistsHut.png");

            newWorld.AddLocation(0, 2, "Herbalist's garden",
                "There are many plants here, with snakes hiding behind them.",
               @"C:\Users\ericsaumier\source\repos\SOSCSRPG\Engine\Images\Locations\HerbalistsGarden.png");


            return newWorld;
        }
    }
}
