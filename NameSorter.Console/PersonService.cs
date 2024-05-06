using System;
using System.Text;

namespace NameSorter.Console
{
  public interface IPersonService
  {
    IEnumerable<Person> Parse(string[] names);
  }

  public class PersonService : IPersonService
  {
    public PersonService()
    {
    }

    public IEnumerable<Person> Parse(string[] names)
    {
      foreach (var name in names)
      {
        if (!string.IsNullOrWhiteSpace(name))
          yield return new Person(name);
      }
    }
  }
}

