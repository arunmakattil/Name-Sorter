using Name_Sorter.Models;
using Name_Sorter.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Sorter.Tests
{
    public class TextFileReaderTests
    {
        [Fact]
        public void ReadNamesFromFile_ValidFilePath_ReturnsNamesList()
        {
            // Arrange
            string filePath = "validFilePath.txt"; 
            File.WriteAllText(filePath, "Jay Prakash\nAmal Gopi");
            var textReader = new TextFileReader();

            // Act
            List<Name> result = textReader.ReadNamesFromFile(filePath);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);

            Assert.Equal("Jay", result[0].GivenNames[0]);
            Assert.Equal("Prakash", result[0].LastName);
            Assert.Equal("Amal", result[1].GivenNames[0]);
            Assert.Equal("Gopi", result[1].LastName);

            // Clean up
            File.Delete(filePath);
        }
        [Fact]
        public void ReadNamesFromFile_InvalidFilePath_ReturnsEmptyList()
        {
            // Arrange
            string filePath = "invalidFilePath.txt";
            var textReader = new TextFileReader();

            // Act
            List<Name> result = textReader.ReadNamesFromFile(filePath);

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }
    }
}
