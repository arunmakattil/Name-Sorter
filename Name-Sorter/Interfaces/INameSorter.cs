using Name_Sorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Sorter.Interfaces
{
    public interface INameSorter
    {
        List<Name> SortNames(List<Name> names);
    }
}
