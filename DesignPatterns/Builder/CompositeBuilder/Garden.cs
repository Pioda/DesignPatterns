using System;

namespace Builder.CompositeBuilder
{
    public class Garden
    {
        public double Area { get; set; }
        public bool GardenHouse { get; set; } = false;
        public bool GrillSpace { get; set; } = false;

        public static HouseGardenBuilder Create(House house)
        {
            house.Garden = new Garden();
            return new HouseGardenBuilder(house);
        }

        protected Garden()
        {

        }

    }
}