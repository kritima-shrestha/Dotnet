using System.Diagnostics.CodeAnalysis;
using Dotnet_Lab_2;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1. program to print hello and your name in a separate line.
        Console.WriteLine("Enter your name:");
        string input = Console.ReadLine();
        Console.WriteLine("Hello!");
        Console.WriteLine(input);

        //2. program to swap two numbers
        Console.WriteLine("Swapping the two numbers");
        Console.WriteLine("Enter 1st number");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 2nd number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("num1=" + num1);
        Console.WriteLine("num2=" + num2);

        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("The swap numbers are");
        Console.WriteLine("num1=" + num1);
        Console.WriteLine("num2=" + num2);


        //3. program to find the largest of three numbers
        Console.WriteLine("finding the largest of three numbers");
        Console.WriteLine("enter first number a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter second number b:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter third number c:");
        int c = Convert.ToInt32(Console.ReadLine());

        CheckNumber largest = new CheckNumber();
        int islarge = largest.CheckLargest(a, b, c);

        Console.WriteLine("The greatest number is:" + islarge);



        //4. program to check whether a given number is even or odd
        Console.WriteLine("To check whether a given number is even or odd");
        Console.WriteLine("Enter a number to check even or odd:");
        int number = Convert.ToInt32(Console.ReadLine());
        CheckNumber oddeven = new CheckNumber();
        bool iseven = oddeven.Checkoddeven(number);
        if (iseven)
        {
            Console.WriteLine("The number " + number +" is even.");
        }
        else
        {
            Console.WriteLine("The number " + number + " is odd.");
        }


        //5. program to find sum of first n natural numbers
        Console.WriteLine("Finding the sum of n natural numbers");
        Console.WriteLine("How many numbers to be taken:");
        int n = Convert.ToInt32(Console.ReadLine());
        Sumof sumnatural = new Sumof();
        int sumn = sumnatural.SumofNatural(n);

        Console.WriteLine("the sum of n natural numbers is: " + sumn);

        //6. program to check leap year
        Console.WriteLine("to check whether the given year is leap year or not");
        Console.WriteLine("enter a year to check whether it is leap year or not:");
        int year = Convert.ToInt32(Console.ReadLine());
        CheckYear leap = new CheckYear();
        bool isleap = leap.CheckLeap(year);
        if (isleap)
        {
            Console.WriteLine("it is leap year.");
        }
        else
        {
            Console.WriteLine("it is not leap year.");
        }

        //7. Program to create integer array and print sum of array elements
        Console.WriteLine("Enter how many number do you want in array:");
        int num = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int [num];
        Console.WriteLine("Enter the numbers for array:");
        for (int k=0; k<num;k++)
        {
            arr[k] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The input array is:");
        for (int j = 0; j < num; j++)
        {
            Console.WriteLine(arr[j]);
        }

        Sumof SumArray = new Sumof();
        int suma = SumArray.SumofArray(arr, num);
        
        Console.WriteLine("The sum of array is: " + suma );

        //8. Program to calculate factorial of given number
        Console.WriteLine("Enter a number to find factorial");
        int num_facto = Convert.ToInt32(Console.ReadLine());
        Factorial Fact = new Factorial();
        int factori = Fact.Facto(num_facto);
        Console.WriteLine("The factorial of given number is: " + factori);

        //9.Program to check whether the given number is prime or not 
        Console.WriteLine("Enter number to check the number is prime or not:");
        int pri_num = Convert.ToInt32(Console.ReadLine());
        CheckNumber prime = new CheckNumber();
        bool isprimecheck = prime.isPrime(pri_num);
        if (isprimecheck)
        {
            Console.WriteLine("The number " + pri_num + " is prime number.");
        }
        else
        {
            Console.WriteLine("The number " + pri_num + " is not prime number.");
        }
            Console.ReadKey();
    }
}