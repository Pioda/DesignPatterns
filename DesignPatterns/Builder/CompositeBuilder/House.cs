using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.CompositeBuilder
{
    public class House
    {
        public int Levels { get; set; }
        public double Area { get; set; }
        public Garden Garden { get; set; }
        public Garage Garage { get; set; }

        public static HouseBuilder Create() => new HouseBuilder(new House());

        protected House()
        {

        }
    }
}
