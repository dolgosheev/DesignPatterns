using System;

namespace Strategy.Entities
{
    public class Entity
    {
        public DateTime Timestamp { get; }
        public string Data { get; }

        public Entity(DateTime timestamp, string data)
        {
            Timestamp = timestamp;
            Data = data;
        }

        public override string ToString()
        {
            return $"Timestamp {Timestamp}: data [{Data}]";
        }
    }
}
