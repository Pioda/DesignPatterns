using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class SingletonDb
    {
        private SingletonDb()
        {
            for (int i = 0; i <= 10; i++)
            {
                InMemoryDb.Add(i, $"Added Index: {i}");
            }
        }

        private static Lazy<SingletonDb> instance = new Lazy<SingletonDb>(() => new SingletonDb());
        public static SingletonDb Instance => instance.Value;

        private Dictionary<int, string> InMemoryDb = new Dictionary<int, string>();

        public string[] Values
        {
            get
            {
                string[] values = new string[InMemoryDb.Keys.Count];
                InMemoryDb.Values.CopyTo(values, 0);
                return values;
            }
        }
    }
}
