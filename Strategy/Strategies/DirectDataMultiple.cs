using Strategy.Entities;
using Strategy.Interfaces;
using System;
using System.Collections.Generic;

namespace Strategy.Strategies
{
    internal class DirectDataMultiple : IReader
    {
        private readonly List<Entity> _result = new();

        public List<Entity> Read()
        {
            return _result;
        }

        public DirectDataMultiple(params string[] data)
        {
            foreach (var dt in data)
            {
                _result.Add(new Entity(DateTime.Now, dt));
            }
            
        }
    }
}
