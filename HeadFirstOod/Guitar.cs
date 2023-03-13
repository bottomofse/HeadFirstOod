﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstOod
{
    class Guitar
    {
        private string serialNumber, builder, model, type, backWood, topWood;
        private double price;

        public Guitar(string serialNumber, double price,
            string builder, string model, string type,
            string backWood, string topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
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
        public string getBuilder()
        {
            return builder;
        }

        public string getModel()
        {
            return model;
        }

        public string getType()
        {
            return type;
        }

        public string getBackWood()
        {
            return backWood;
        }

        public string getTopWood()
        {
            return topWood;
        }

    }
}