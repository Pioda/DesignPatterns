using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.CompositeBuilder
{
    public class HouseDirector
    {
        HouseBuilder builder;

        public HouseDirector(HouseBuilder builder)
        {
            this.builder = builder;
        }

        public House CreateMediumSizedHouseWithGarage()
        {
            return builder
                .WithArea(150.75)
                .WithLevels(2)
                .WithGarage()
                    .WithGarageCarSpace(2)
                    .WithGarageArea(20);
        }

    }
}
