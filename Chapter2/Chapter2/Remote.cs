using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Chapter2
{
    class Remote
    {
        private DogDoor door;

        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public void pressButton()
        {
            Console.WriteLine("リモコンのボタンが押された...");
            if (door.isOpen())
            {
                door.close();
            }
            else
            {
                door.open();
                Timer timer = new Timer(5000);
                timer.Elapsed += (sender, e) => {
                    door.close();
                    timer.Stop();
                    timer.Dispose();
                };
                timer.AutoReset = false;
                timer.Enabled = true;
                timer.Start();
                Console.ReadLine();
            }
        }
    }
}
