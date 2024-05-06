using System;
namespace NameSorter.Console
{
  public class Person
  {
    public Person(string fullName)
    {
      if (string.IsNullOrWhiteSpace(fullName)) return;

      var lastSpaceIndex = fullName.LastIndexOf(" ");
      if (lastSpaceIndex > 0)
      {
        LastName = fullName[lastSpaceIndex..]?.Trim() ?? string.Empty;
        GivenName = fullName[..lastSpaceIndex]?.Trim() ?? string.Empty;
      }
      else
      {
        LastName = fullName;
      }
    }

    public string LastName { get; set; } = "";
    public string GivenName { get; set; } = "";

    public string FullName => $"{GivenName} {LastName}";
  }
}

