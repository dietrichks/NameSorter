// See https://aka.ms/new-console-template for more information

using NameSorter.Console;
public class Program
{
  public static void Main(string[] args)
  {
    if (args == null || args.Length <= 0 || string.IsNullOrWhiteSpace(args[0])) throw new ArgumentException("File path is expected!");


    if (!File.Exists(args[0])) throw new FileNotFoundException();

    var unsortedNames = File.ReadAllLines(args[0]);
    var sortedList = new NameSorter.Console.NameSorter(new PersonService()).Sort(unsortedNames);

    var output = string.Join(Environment.NewLine, sortedList);
    Console.WriteLine(output);

    File.WriteAllText("sorted-names-list.txt", output);
  }
}

