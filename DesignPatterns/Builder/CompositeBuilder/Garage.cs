namespace Builder.CompositeBuilder
{
    public class Garage
    {
        public double Area { get; set; }
        public int CarSpaces { get; set; }

        protected Garage()
        {

        }

        public static HouseGarageBuilder Create(House house)
        {
            house.Garage = new Garage();
            return new HouseGarageBuilder(house);
        }
    }
}