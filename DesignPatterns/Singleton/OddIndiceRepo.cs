using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class OddIndiceRepo
    {
        private SingletonDb db;
        public OddIndiceRepo()
        {
            db = SingletonDb.Instance;
        }

        public List<string> Get()
        {
            var values = new List<string>();
            for (int i = 0; i < db.Values.Count(); i++)
            {
                if (i % 2 != 0)
                    values.Add(db.Values[i]);
            }
            return values;
        }
    }
}
