using NameSorter.Console;

namespace NameSorter.Tests;

public class PersonTest
{
  [Theory]
  [InlineData("Adonis Julius Archer", "Adonis Julius", "Archer")]
  [InlineData("Vaughn Lewis", "Vaughn", "Lewis")]
  [InlineData("Hunter Uriah Mathew Clarke", "Hunter Uriah Mathew", "Clarke")]
  [InlineData("Doe", "", "Doe")]
  [InlineData("", "", "")]
  public void Initialize_Person_Should_Set_GivenAndLast_Name(string fullName, string expectedGivenName, string expectedLastName)
  {
    var person = new Person(fullName);
    Assert.Equal(expectedGivenName, person.GivenName);
    Assert.Equal(expectedLastName, person.LastName);
  }
}
