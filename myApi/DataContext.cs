//using CsvHelper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace myApi
{
    public class DataContext:IDataCotext
    {
     
        public List<Event> Events { get; set; }
        //public int Count { get; set; }
        int count = 0;

        public DataContext()
        {

            //using (var reader = new StreamReader("data.csv"))
            //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            //{
            //    Events = csv.GetRecords<Event>().ToList();
            //}
            Events = new List<Event>();
            Events.Add(new Event { Id = count++, Title = "holiday", Start = new DateTime(2023, 10, 5) });
            Events.Add(new Event { Id = count++, Title = "nice", Start = new DateTime(2023, 11, 4) });
            Events.Add(new Event { Id = count++, Title = "happy", Start = new DateTime(2023, 11, 10) });
            Events.Add(new Event { Id = count++, Title = "shabbos", Start = new DateTime(2023, 11, 19) });

        }
    }
}
