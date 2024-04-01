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
            
            // Sort the names first by last name, then by given names. If the last name is not present it will sort at the end
            sortedList = names.OrderBy(n => n.LastName==string.Empty ? 1 : 0)
                              .ThenBy(n => (n.LastName))
                              .ThenBy(n => string.Join(" ", n.GivenNames))
                              .ToList();
            return sortedList;
        }
    }
}
