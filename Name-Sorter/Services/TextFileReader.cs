﻿using Name_Sorter.Interfaces;
using Name_Sorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Sorter.Services
{
    public class TextFileReader: ITextFileReader
    {
        /// <summary>
        /// Reads names from a text file at the specified file path.
        /// </summary>
        /// <param name="filePath">File path of the text file</param>
        /// <returns>The list of names</returns>
        public List<Name> ReadNamesFromFile(string filePath)
        {
            List<Name> names = new List<Name>();

            try
            {
                // Open the file for reading
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            // Parse the name from the line and add it to the list
                            Name name = ParseNameFromLine(line);
                            names.Add(name);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }

            return names;
        }

        // Parses a single name from a line of text.
        private Name ParseNameFromLine(string line)
        {
            // Split the line into parts
            string[] nameParts = line.Split(' ');

            // The last part is taken as the last name
            string lastName = string.Empty;
            List<string> givenNames = new List<string>();
            if (nameParts.Length == 1)
            {
                givenNames = nameParts.Take(nameParts.Length).ToList();
            }
            else
            {
                lastName = nameParts.Last();
                // The remaining parts are taken as given names
                givenNames = nameParts.Take(nameParts.Length - 1).ToList();
            }

            // Returns a new Name object as lat name and list of given names
            return new Name
            {
                LastName = lastName,
                GivenNames = givenNames
            };
        }
    }
}
