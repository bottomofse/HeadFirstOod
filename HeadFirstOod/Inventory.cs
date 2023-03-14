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
            Builder builder, string model, Type type,
            Wood backWood, Wood topWood)
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
                if (searchGuitar.getBuilder() != guitar.getBuilder())
                {
                    continue;
                }
                string model = searchGuitar.getModel();
                if (model != null && !model.Equals("") && !model.Equals(guitar.getModel()))
                {
                    continue;
                }
                if (searchGuitar.getType() != guitar.getType())
                {
                    continue;
                }
                if (searchGuitar.getBackWood() != guitar.getBackWood())
                {
                    continue;
                }
                if (searchGuitar.getTopWood() != guitar.getTopWood())
                {
                    continue;
                }
                return guitar;
            }
            return null;
        }
    }
}
