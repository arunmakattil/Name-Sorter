using Name_Sorter.Interfaces;
using Name_Sorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Sorter.Services
{
    public class NameSorter : INameSorter
    {
        // Method to sort a list of names
        public List<Name> SortNames(List<Name> names)
        {
            List<Name> sortedList=new List<Name>();
            // Sort the names first by last name, then by given names
            sortedList = names.OrderBy(n => n.LastName)
                              .ThenBy(n => string.Join(" ", n.GivenNames))
                              .ToList();
            // Return the sorted list of names
            return sortedList;
        }
    }
}
