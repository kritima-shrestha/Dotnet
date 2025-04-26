using Class_Work;
using static class_activity.Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        MathOperations maths = new MathOperations();
        var addInt = maths.Add(7, 9);
        Console.WriteLine("Addition of two integers =" + addInt);
        var addDouble = maths.Add(79.62, 88.12);
        Console.WriteLine("Addition of two Doubles =" + addDouble);
        var mulInt = maths.Multiply(7, 9);
        Console.WriteLine("Multiply of two integers =" + mulInt);
        var mulDouble = maths.Multiply(8.15, 7.12);
        Console.WriteLine("Multiply of two doubles =" + mulDouble);

        MathOperation iO = new MathOperation();
        var addIdouble = iO.Add(6.5, 4.0);
        Console.WriteLine("Addition of two Doubles =" + addIdouble);
        var subIdouble = iO.Subtract(7.6, 3.0);
        Console.WriteLine("Addition of two Doubles =" + subIdouble);
        var mulIdouble = iO.Multiply(7.5, 4.0);
        Console.WriteLine("Multiply of two Doubles =" + mulIdouble);
        var divIdouble = iO.Add(5.5, 3.0);
        Console.WriteLine("Addition of two Doubles =" + addIdouble);

        Console.WriteLine("Enter a word to check palindrome:");
        string inputstr =Console.ReadLine();
        Palindrome palin = new Palindrome();
        bool ispalin = palin.checkpalin(inputstr);
        if (ispalin)
        {
            Console.WriteLine("The word " + inputstr + " is palindrome.");
        }
        else
        {
            Console.WriteLine("The word " + inputstr + " is not palindrome.");
        }
    }
}