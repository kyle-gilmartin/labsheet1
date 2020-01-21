using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1
{
    public class Band:IComparable
    {
        public string BandName { get; set; }
        public DateTime Year { get; set; }
        public string Members { get; set; }

        public Band(string bandName, DateTime year, string members)
        {
            BandName = bandName;
            Year = year;
            Members = members;
        }

        public Band()
        {
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{BandName}";
        }
    }
}
