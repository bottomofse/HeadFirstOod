using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            Console.WriteLine("\nFidoが用をすます");
            try
            {
                Thread.Sleep(8000);
            }
            catch (ThreadInterruptedException){ }
            Console.WriteLine("...しかしまだ外にいる！");
            Console.WriteLine("\nFidoが吠え始める");
            Console.WriteLine("...そこでToddがリモコンをつかむ");
            remote.pressButton();
            Console.WriteLine("\nFidoが家の中に戻る");

        }
    }
}
