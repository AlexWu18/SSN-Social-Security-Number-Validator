using System.Text.RegularExpressions;

internal class program
{
    private static void Main(string[] args)
    {  
        // can't be 666 or 000, second part need to be (01-99) and not three number, the last part different to 0000 (only four number)
        string PatternSSN = "^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$"; 
        Regex regex = new Regex(PatternSSN);// create a Regular expression that have the three conditions

        bool Example1 = regex.IsMatch("736-21-5481"); //that example are "true" because comply the three conditions.
        bool Example2 = regex.IsMatch("666-25-0254"); // In that case is "False" because start with 666
        bool Example3 = regex.IsMatch("156-212-5561");// is "False" because the second part before the hyphen have three number intead of two 
        bool Example4 = regex.IsMatch("695-55-0000"); // Is "False because" the third part end with 0000
        bool Example5 = regex.IsMatch("001-21-9514");

        //Show results
        Console.WriteLine("Example 1 = " + Example1); 
        Console.WriteLine("Example 2 = " + Example2);
        Console.WriteLine("Example 3 = " + Example3);
        Console.WriteLine("Example 4 = " + Example4);
        Console.WriteLine("Example 5 = " + Example5);

        Console.ReadLine();

    }

}