using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstOod
{
    class Guitar
    {
        private string serialNumber;
        private double price;
        private GuitarSpec spec;

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }

        public string getSerialNumber()
        {
            return serialNumber;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double newPrice)
        {
            price = newPrice;
        }

        public GuitarSpec getGuitarSpec()
        {
            return spec;
        }
        

    }

    public class GuitarSpec
    {
        private Builder builder;
        private string model;
        private Type type;
        private Wood backWood;
        private Wood topWood;
        private int numStrings;

        public GuitarSpec(Builder builder, string model,
            Type type, Wood backwood, Wood topwood, int numStrings)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backwood;
            this.topWood = topwood;
            this.numStrings = numStrings;
        }

        public bool matches(GuitarSpec spec)
        {
            if (this.builder != spec.getBuilder()) return false;
            if (this.model != spec.getModel()) return false;
            if (this.type != spec.getType()) return false;
            if (this.backWood != spec.getBackWood()) return false;
            if (this.topWood != spec.getTopWood()) return false;
            if (this.numStrings != spec.numStrings) return false;
            return true;
        }

        public Builder getBuilder()
        {
            return builder;
        }
        public string getModel()
        {
            return model;
        }

        public Type getType()
        {
            return type;
        }

        public Wood getBackWood()
        {
            return backWood;
        }

        public Wood getTopWood()
        {
            return topWood;
        }

        public int getNumStrings()
        {
            return numStrings;
        }
    }

    public enum Type
    {
        ACOUSTIC, ELECTRIC
    }

    public enum Builder
    {
        FENDER, MARTIN, GIBSON, COllINGS, OLSON, RYAN, PRS, ANY
    }

    public enum Wood
    {
        BLASILIAN_ROSEWOOD, MAHOGANY,MAPLE, COCOBOLO, CEDAR, ADIRONDACK, ALDER, SITKA 
    }

}
