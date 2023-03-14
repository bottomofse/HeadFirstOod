using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstOod
{
    class FindGuitarTester
    {
        public void exec()
        {
            Inventory inventory = new Inventory();
            initializeInevntory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocastor",
            Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
            List<Guitar> matchingGuitars = inventory.search(whatErinLikes);
            if (matchingGuitars.Count > 0)
            {
                foreach (var guitar in matchingGuitars)
                {
                    GuitarSpec guitarspec = guitar.getGuitarSpec();
                    Console.WriteLine("Erin, you might like this " + guitarspec.getBuilder() + " " + guitarspec.getModel()
                    + " " + guitarspec.getType() + " guitar: \n " + guitarspec.getBackWood() + " back and side.\n "
                    + guitarspec.getTopWood() + " top.\nYou can have it for only $" + guitar.getPrice() + "!\n-----");
                }
            }
            else
            {
                Console.WriteLine("Sorry. Erin, we have nothing for you.");
            }
        }

        private void initializeInevntory(Inventory inventory)
        {
            inventory.addGuitar("V95693",1499.95, Builder.FENDER,"Stratocastor",Type.ELECTRIC,Wood.ALDER,Wood.ALDER);
            inventory.addGuitar("K18693", 1568.99, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
        }
    }
}
