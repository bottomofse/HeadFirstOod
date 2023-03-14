using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class DogDoor
    {
        private bool open_state;

        public DogDoor()
        {
            open_state = false;
        }

        public void open()
        {
            Console.WriteLine("犬用ドアが開く");
            open_state = true;
        }

        public void close()
        {
            Console.WriteLine("犬用ドアが閉まる");
            open_state = false;
        }

        public bool isOpen()
        {
            return open_state;
        }


    }
}
