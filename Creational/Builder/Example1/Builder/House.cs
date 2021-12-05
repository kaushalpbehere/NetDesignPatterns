using System;
using System.Collections.Generic;

namespace Builder.Example1.Builder
{
    public class House
    {
        readonly List<string> houseComponents = new();

        public void Add(string component)
        {
            houseComponents.Add(component);
        }

        public void Build()
        {
            foreach (var house in houseComponents)
                Console.WriteLine(house);
        }
    }
}