using Name_Sorter.Interfaces;
using Name_Sorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Sorter.Services
{
    //Service for writing sorted names to a text file.
    public class TextFileWriter: ITextFileWriter
    {
        /// <summary>
        /// Writes the sorted names to the specified text file.
        /// </summary>
        /// <param name="names">List of names that need to write</param>
        /// <param name="sortedNamesFileName">File name where the names need to write</param>
        public void WriteNamesToFile(List<Name> names, string sortedNamesFileName)
        {
            try
            {
                // Check if the list of names is empty
                if (names.Count == 0)
                {
                    throw new ArgumentException("The sorted names list is empty, no names are available.");
                }

                // Display the sorted names to the console screen
                DisplayNamesToScreen(names);

                // Write sorted names to the specified text file
                using (StreamWriter writer = new StreamWriter(sortedNamesFileName))
                {
                    foreach (var name in names)
                    {
                        writer.WriteLine(name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }
        private void DisplayNamesToScreen(List<Name> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
