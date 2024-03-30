using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Sorter.Models
{
    public class Name
    {
        public string LastName { get; set; }
        public List<string> GivenNames { get; set; }

        public override string ToString()
        {
            return string.Join(" ", GivenNames) + " " + LastName;
        }
    }
}
