using System.Text.RegularExpressions;

internal class program
{
    private static void Main(string[] args)
    {
        string PatternSSN = "^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$"; // create a Regular expression that have the three conditions
        Regex regex = new Regex(PatternSSN);

        bool Example1 = regex.IsMatch("736-21-5481");
        bool Example2 = regex.IsMatch("666-25-0254");
        bool Example3 = regex.IsMatch("156-212-5561");
        bool Example4 = regex.IsMatch("695-55-0000");
        bool Example5 = regex.IsMatch("001-21-9514");
        Console.WriteLine("Example 1 = " + Example1);
        Console.WriteLine("Example 2 = " + Example2);
        Console.WriteLine("Example 3 = " + Example3);
        Console.WriteLine("Example 4 = " + Example4);
        Console.WriteLine("Example 5 = " + Example5);

        Console.ReadLine();

    }

}