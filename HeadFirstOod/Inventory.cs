using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstOod
{
    class Inventory
    {
        private List<Guitar> guitars = new List<Guitar>();

        public void addGuitar(string serialNumber, double price,
            string builder, string model, string type,
            string backWood, string topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
            guitars.Add(guitar);
        }

        public Guitar getGuitar(string serialNumber)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.getSerialNumber().Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }

        public Guitar search(Guitar searchGuitar)
        {
            foreach (var guitar in guitars)
            {
                string builder = searchGuitar.getBuilder();
                if (builder != null && !builder.Equals("") && !builder.Equals(guitar.getBuilder()))
                {
                    continue;
                }
                string model = searchGuitar.getModel();
                if (model != null && !model.Equals("") && !model.Equals(guitar.getModel()))
                {
                    continue;
                }
                string type = searchGuitar.getType();
                if (type != null && !type.Equals("") && !type.Equals(guitar.getType()))
                {
                    continue;
                }
                string backWood = searchGuitar.getBackWood();
                if (backWood != null && !backWood.Equals("") && !backWood.Equals(guitar.getBackWood()))
                {
                    continue;
                }
                string topWood = searchGuitar.getTopWood();
                if (topWood != null && !topWood.Equals("") && !topWood.Equals(guitar.getTopWood()))
                {
                    continue;
                }
                return guitar;
            }
            return null;
        }


    }
}
