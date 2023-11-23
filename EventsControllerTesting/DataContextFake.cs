using myApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    internal class DataContextFake:IDataCotext
      {          
        public List<Event> Events { get; set; }
        //public int Count { get; set; }
        int count = 0;
        public DataContextFake()
        {
            Events = new List<Event>();
            Events.Add(new Event { Id = count++, Title = "holiday", Start = new DateTime(2023, 10, 5) });
            Events.Add(new Event { Id = count++, Title = "nice", Start = new DateTime(2023, 11, 4) });
            Events.Add(new Event { Id = count++, Title = "happy", Start = new DateTime(2023, 11, 10) });
            Events.Add(new Event { Id = count++, Title = "shabbos", Start = new DateTime(2023, 11, 19) });
        }

    }
}
