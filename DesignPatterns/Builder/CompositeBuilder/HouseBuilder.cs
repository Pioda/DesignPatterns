using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.CompositeBuilder
{
    public class HouseBuilder
    {
        protected House House;

        public HouseBuilder(House house)
        {
            House = house;
        }

        public HouseBuilder WithArea(double area)
        {
            House.Area = area;
            return this;
        }

        public HouseBuilder WithLevels(int levels)
        {
            House.Levels = levels;
            return this;
        }

        public HouseGarageBuilder WithGarage() => Garage.Create(House);

        public HouseGardenBuilder WithGarden() => Garden.Create(House);

        public static implicit operator House(HouseBuilder houseBuilder) => houseBuilder.House;

    }
}
