//using System.ComponentModel.DataAnnotations;
//using System.Threading.Tasks;

//Create a method called NumberStats that accepts a number. This method should:

//Find out if the number is negative or positive

//Find out if the number is odd or even

//Find out if the number is decimal or integer

//After finding all the stats it should print them like this:

//Stats for number: 25

//Positive
//Integer
//Odd
//The number should be entered in the console by the user.

//Bonus: Validate if the user is entering a number

//Bonus: Ask the user to press Y to try again or X to exit
while (true)
{

    Console.WriteLine("Please write a number: ");
    string userInput = Console.ReadLine();



    if (double.TryParse(userInput, out double num))
    {
        Console.WriteLine($"You entered this number {num}");
        if (num % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }
        if (num < 0)
        {
            Console.WriteLine("Number is negative");
        }
        else
        {
            Console.WriteLine("Number is positive");
        }
        if (num % 1 == 0)
        {
            Console.WriteLine("Number is Whole");
        }
        else
        {
            Console.WriteLine("Number is Decimal");
        }
    }
    else
    {
        Console.WriteLine("Please enter a number...");
    }
    string exit = Console.ReadLine();
    if(exit == "y")
    {
        break;
    }
    else
    {
        continue;
    }
}