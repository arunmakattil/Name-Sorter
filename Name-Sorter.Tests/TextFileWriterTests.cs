using Name_Sorter.Models;
using Name_Sorter.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Sorter.Tests
{
    public class TextFileWriterTests
    {
        // Test to verify that the WriteNamesToFile method writes all the names correctly to the specified file path.
        [Fact]
        public void WriteNamesToFile_PassListOfName_ShouldWriteTogivenFileName()
        {

            //Arrange
            List<Name> names = new List<Name>
            {
                new Name { LastName = "Krishna", GivenNames = new List<string> { "Avinash", "Joshi" } }
            };
            string sortedNamesFileName = "test_output.txt";

            // Act
            TextFileWriter fileWriter = new TextFileWriter();
            fileWriter.WriteNamesToFile(names, sortedNamesFileName);

            // Assert
            Assert.True(File.Exists(sortedNamesFileName));

            // Clean-up
            File.Delete(sortedNamesFileName);
        }

        // Test to verify that the WriteNamesToFile method skip writing file if the given list is empty.
        [Fact]
        public void WriteNamesToFile_EmptyNameList_ShouldNotCreateFile()
        {
            // Arrange
            var names = new List<Name>();
            string sortedNamesFileName = "test_output.txt";

            // Act
            var fileWriter = new TextFileWriter();
            fileWriter.WriteNamesToFile(names, sortedNamesFileName);

            // Assert
            Assert.False(File.Exists(sortedNamesFileName));

            // Clean-up
            if(File.Exists(sortedNamesFileName))
            File.Delete(sortedNamesFileName);
        }
    }
}
