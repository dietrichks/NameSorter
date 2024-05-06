using System;
namespace NameSorter.Console
{
  public class NameSorter
  {
    private readonly IPersonService _personService;

    public NameSorter(IPersonService personService)
    {
      _personService = personService;
    }

    public string[] Sort(string[] names)
    {
      var persons = _personService.Parse(names).ToList();

      var sortedPersons = persons
                        .OrderBy(p => p.LastName)
                        .ThenBy(p => p.GivenName)
                        .ToList();

      return sortedPersons.Select(p => p.FullName).ToArray();
    }
  }
}

