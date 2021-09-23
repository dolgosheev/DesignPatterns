using Strategy.Entities;
using System.Collections.Generic;

namespace Strategy.Interfaces
{
    public interface IReader
    {
         public List<Entity> Read();
    }
}
