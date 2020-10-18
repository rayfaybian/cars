using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    enum Type { Sportauto, PKW }
    class Car
    {
        private Enum type;
        public Enum _type
        {
            get { return type; }
            set { type = value; }
        }

        private String producer;

        public String _producer
        {
            get { return producer; }
            set { producer = value; }
        }

        private String name;

        public String _name
        {
            get { return name; }
            set { name = value; }
        }

        private String year;

        public String _year
        {
            get { return year; }
            set { year = value; }
        }

        private String color;

        public String _color
        {
            get { return color; }
            set { color = value; }
        }

        public override string ToString()
        {
            String carDetails =
                "\nType: " + type +
                "\nHersteller: " + producer +
                "\nModell: " + name +
                "\nFarbe: " + color +
                "\nBaujahr: " + year + "\n";
            return carDetails;
        }
    }
}
