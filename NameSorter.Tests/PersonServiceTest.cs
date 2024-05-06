using System;
using NameSorter.Console;

namespace NameSorter.Tests
{
  public class PersonServiceTest
  {
    private readonly PersonService _SUT;
    public PersonServiceTest()
    {
      _SUT = new PersonService();
    }

    [Fact]
    public void Parse_ShouldReturn_ListOfPerson()
    {
      var names = new[] { "Janet Parsons", "Beau Tristan Bentley", "Leo Gardner", "" };
      var persons = _SUT.Parse(names).ToList();
      Assert.NotEmpty(persons);
      Assert.Equal(3, persons.Count);
    }

  }
}

