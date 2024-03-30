using FluentAssertions;
using Name_Sorter.Models;
using Name_Sorter.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Name_Sorter.Tests
{
    public class NameSorterMainTests
    {
        [Fact]
        public void SortNames_WithUnsortedListOfNames_ShouldSortInOrder()
        {
            // Arrange
            var sorter = new NameSorter();
            var unsortedNamesList = new List<Name>
            {
                new Name { LastName = "Smith", GivenNames = new List<string> { "John", "David" } },
                new Name { LastName = "Johnson", GivenNames = new List<string> { "Alice" } },
                new Name { LastName = "Adams", GivenNames = new List<string> { "Robert", "James" } }
            };
           
            // Act
            var sortedNamesList = sorter.SortNames(unsortedNamesList);

            // Assert
            sortedNamesList.Should().HaveCount(3);
            Assert.Equal("Robert James Adams", sortedNamesList[0].ToString());
            Assert.Equal("Alice Johnson", sortedNamesList[1].ToString());
            Assert.Equal("John David Smith", sortedNamesList[2].ToString());
        }
        [Fact]
        public void SortNames_WithSameLastNameAndDiffGivenName_ShouldSortNamesInOrder()
        {
            // Arrange
            var sorter = new NameSorter();
            var unsortedNames = new List<Name>
            {
                new Name { LastName = "Smith", GivenNames = new List<string> { "John", "David" } },
                new Name { LastName = "Smith", GivenNames = new List<string> { "Alice" } },
                new Name { LastName = "Smith", GivenNames = new List<string> { "Robert", "James" } }
            };

            // Act
            var sortedNames = sorter.SortNames(unsortedNames);

            // Assert
            Assert.Equal("Alice Smith", sortedNames[0].ToString());
            Assert.Equal("John David Smith", sortedNames[1].ToString());
            Assert.Equal("Robert James Smith", sortedNames[2].ToString());
        }
    }
}
