using Strategy.Entities;
using Strategy.Interfaces;
using System;
using System.Collections.Generic;

namespace Strategy.Strategies
{
    internal class DirectDataSingle : IReader
    {
        private readonly List<Entity> _result = new();

        public List<Entity> Read()
        {
            return _result;
        }

        public DirectDataSingle(DateTime timestamp,string data)
        {
            _result.Add(new Entity(timestamp,data));
        }
    }
}
