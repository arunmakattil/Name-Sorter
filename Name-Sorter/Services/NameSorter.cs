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
        /// <summary>
        /// Method to sort a list of names
        /// </summary>
        /// <param name="names">The list of unsorted names</param>
        /// <returns>The list of sorted names</returns>
        public List<Name> SortNames(List<Name> names)
        {
            List<Name> sortedList=new List<Name>();
            // Sort the names first by last name, then by given names
            sortedList = names.OrderBy(n => n.LastName)
                              .ThenBy(n => string.Join(" ", n.GivenNames))
                              .ToList();
            return sortedList;
        }
    }
}
