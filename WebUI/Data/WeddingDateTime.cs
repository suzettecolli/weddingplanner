using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Data
{
    public class WeddingDateTime
    {
        public DateTimeModel celebrationDateTime { get; set; } = new DateTimeModel() { Day = "1", Month = "1", Year = "2020", Hour = "1", Minute = "0" };
        public DateTimeModel ceremonyDateTime { get; set; } = new DateTimeModel() { Day = "1", Month = "1", Year = "2020", Hour = "1", Minute = "0" };
        public List<Month> months = new List<Month>(){
            new Month() { Name = "Prosinec", Number = 12 },
            new Month() { Name = "Listopad", Number = 11 },
            new Month() { Name = "Říjen", Number = 10 },
            new Month() { Name = "Září", Number = 9 },
            new Month() { Name = "Srpen", Number = 8 },
            new Month() { Name = "Červenec", Number = 7 },
            new Month() { Name = "Červen", Number = 6 },
            new Month() { Name = "Květen", Number = 5 },
            new Month() { Name = "Duben", Number = 4 },
            new Month() { Name = "Březen", Number = 3 },
            new Month() { Name = "Únor", Number = 2 },
            new Month() { Name = "Leden", Number = 1 }
        };
        public class Month
        {
            public int Number { get; set; }
            public string Name { get; set; }
        }

        public class DateTimeModel
        {
            public string Day { get; set; }
            public string Month { get; set; }
            public string Year { get; set; }
            public string Hour { get; set; }
            public string Minute { get; set; }
        }
    }
}
