using Name_Sorter.Interfaces;
using Name_Sorter.Models;
using Name_Sorter.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Sorter
{
    public class NameSorterMain
    {
        // Main entry point for the Name Sorter application.
        public static void Main(string[] args)
        {
            // Check if the correct number of arguments are provided
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: name-sorter <file-path>");
                return;
            }
            //File name to save the sorted name list
            string sortedNamesFileName = "sorted-names-list.txt";

            ITextFileReader fileReader = new TextFileReader();
            ITextFileWriter fileWriter = new TextFileWriter();
            INameSorter nameSorter = new NameSorter();

            // Get the file path from command line arguments
            string filePath = args[0];

            List<Name> names = fileReader.ReadNamesFromFile(filePath); //Read names from the input file

            List<Name> sortedNames = nameSorter.SortNames(names); //Sort the names

            //Write the sorted names to text file and disply names on screen
            fileWriter.WriteNamesToFile(sortedNames, sortedNamesFileName);

        }
    }
}
