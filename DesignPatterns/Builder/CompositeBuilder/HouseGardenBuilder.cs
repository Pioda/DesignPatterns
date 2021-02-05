namespace Builder.CompositeBuilder
{
    public class HouseGardenBuilder : HouseBuilder
    {
        public HouseGardenBuilder(House house) : base (house)
        {
        }

        public HouseGardenBuilder WithGardenArea(double area)
        {
            House.Garden.Area = area;
            return this;
        }

        public HouseGardenBuilder WithGardenHouse()
        {
            House.Garden.GardenHouse = true;
            return this;
        }
        public HouseGardenBuilder WithGrillSpace()
        {
            House.Garden.GrillSpace = true;
            return this;
        }

        public static implicit operator Garden(HouseGardenBuilder houseGardenBuilder) => houseGardenBuilder.House.Garden;
    }
}