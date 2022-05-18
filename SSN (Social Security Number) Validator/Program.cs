using System.Text.RegularExpressions;

internal class program
{
    private static void Main(string[] args)
    {
        string PatternSSN = "^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$";
        Regex regex = new Regex(PatternSSN);

        bool Example1 = regex.IsMatch("736-21-5481");
        Console.Write(Example1);
        Console.ReadLine();

    }

}