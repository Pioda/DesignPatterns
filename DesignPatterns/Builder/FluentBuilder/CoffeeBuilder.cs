using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FluentBuilder
{
    public class CoffeeBuilder
    {
        protected Coffee coffee;
        public CoffeeBuilder(Coffee baseCoffee)
        {
            coffee = baseCoffee;
        }
        public CoffeeBuilder BlackCoffee()
        {
            coffee.Content += "Black";
            coffee.Price += 1.5;
            return this;
        }

        public CoffeeBuilder WithMilk()
        {
            coffee.Price += 0.5;
            coffee.Content += ", Milk";
            return this;
        }

        public CoffeeBuilder WithRum()
        {
            coffee.Price += 1;
            coffee.Content += ", Rum";
            return this;
        }

        public Coffee Pour() => coffee;

        public static implicit operator Coffee(CoffeeBuilder builder) => builder.coffee;
    }
}
