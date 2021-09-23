using Strategy.Strategies;
using System;

namespace Strategy
{
    internal class Program
    {
        private static void Main()
        {
            var processor = new Processor(new DirectDataSingle(DateTime.Now, "Start Message" ),
                new DirectDataMultiple("Hi","Hello","OLOLO")
                );

            processor.ReadAll();
        }
    }
}