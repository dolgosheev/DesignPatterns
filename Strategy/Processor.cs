using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    internal class Processor
    {
        private readonly IList<IReader> _entityContexts;

        public Processor(params IReader[] strategies)
        {
            _entityContexts = strategies;
        }

        public void ReadAll()
        {
            _entityContexts.ToList().ForEach(ReadSource);
        }

        private void ReadSource(IReader source)
        {
            (source.Read()).ForEach(Console.WriteLine);
        }
    }
}
