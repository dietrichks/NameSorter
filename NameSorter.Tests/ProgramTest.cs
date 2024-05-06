using System;
namespace NameSorter.Tests
{
  public class ProgramTest
  {
    public ProgramTest()
    {
    }

    [Fact]
    public void Main_Without_Args_ShouldThrow_ArgumentException()
    {
      Assert.Throws<ArgumentException>(() => Program.Main(Array.Empty<string>()));
    }

    [Fact]
    public void Main_FileNotFound_ShouldThrow_FileNotFoundException()
    {
      Assert.Throws<FileNotFoundException>(() => Program.Main(new[] { "dummy-file.txt" }));
    }

    [Fact]
    public void Main_ShouldExecute_Sort()
    {
      Program.Main(new[] { @"Data/unsorted-names-list.txt" });
    }
  }
}

