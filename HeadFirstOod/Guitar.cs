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

        public Guitar(string serialNumber, double price,
            Builder builder, string model, Type type,
            Wood backWood, Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = new GuitarSpec(builder, model, type, backWood, topWood);
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

        public GuitarSpec(Builder builder, string model, Type type, Wood backwood, Wood topwood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backwood;
            this.topWood = topwood;
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
