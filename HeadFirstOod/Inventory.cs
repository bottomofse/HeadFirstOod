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

        public List<Guitar> search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (var guitar in guitars)
            {
                GuitarSpec guitarspec = guitar.getGuitarSpec();
                if (searchSpec.getBuilder() != guitarspec.getBuilder())
                {
                    continue;
                }
                string model = searchSpec.getModel();
                if (model != null && !model.Equals("") && !model.Equals(guitarspec.getModel()))
                {
                    continue;
                }
                if (searchSpec.getType() != guitarspec.getType())
                {
                    continue;
                }
                if (searchSpec.getBackWood() != guitarspec.getBackWood())
                {
                    continue;
                }
                if (searchSpec.getTopWood() != guitarspec.getTopWood())
                {
                    continue;
                }
                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
