using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class DogDoorSimulator
    {
        public void exec()
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("Fidoが外に出たいと吠える...");
            remote.pressButton();
            Console.WriteLine("\nFidoが外に出る...");
            //remote.pressButton();
            //Console.WriteLine("\nFidoが用をすます...");
            //remote.pressButton();
            //Console.WriteLine("\nFidoが家の中に戻る");
            //remote.pressButton();
        }
    }
}
