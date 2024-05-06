using System;
using Moq;
using NameSorter.Console;
namespace NameSorter.Tests
{
  public class NameSorterTest
  {
    private readonly Mock<IPersonService> personServiceMock;
    private readonly NameSorter.Console.NameSorter _SUT;
    public NameSorterTest()
    {
      personServiceMock = new Mock<IPersonService>();
      _SUT = new NameSorter.Console.NameSorter(personServiceMock.Object);
    }

    [Fact]
    public void Sort_ShouldReturn_SortedList()
    {
      var persons = new Person[] { new Person("Janet Parsons"), new Person("Beau Tristan Bentley"), new Person("Leo Gardner") };

      personServiceMock.Setup(m => m.Parse(It.IsAny<string[]>())).Returns(persons);

      var result = _SUT.Sort(new[] { "Janet Parsons", "Beau Tristan Bentley", "Leo Gardner" });

      Assert.Equal("Beau Tristan Bentley", result[0]);
      Assert.Equal("Leo Gardner", result[1]);
      Assert.Equal("Janet Parsons", result[2]);
    }
  }
}

