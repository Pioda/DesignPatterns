using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.CompositeBuilder
{
    public class HouseGarageBuilder : HouseBuilder
    {
        public HouseGarageBuilder(House house) : base(house)
        {
        }

        public HouseGarageBuilder WithGarageArea(double area)
        {
            House.Garage.Area = area;
            return this;
        }

        public HouseGarageBuilder WithGarageCarSpace(int carSpaces)
        {
            House.Garage.CarSpaces = carSpaces;
            return this;
        }

        public static implicit operator Garage(HouseGarageBuilder houseGarageBuilder) => houseGarageBuilder.House.Garage;
    }
}
