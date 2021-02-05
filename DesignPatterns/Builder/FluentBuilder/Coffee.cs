using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FluentBuilder
{
    public class Coffee
    {
        public double Price { get; set; }
        public string Content { get; set; }

        protected Coffee()
        {
        }

        public override string ToString() => $"Coffee content: {Content}\nPrice: {Price}€";

        public static CoffeeBuilder Create() => new CoffeeBuilder(new Coffee());
    }
}
