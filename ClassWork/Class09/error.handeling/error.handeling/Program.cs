
#region

using System.ComponentModel.Design;

Console.WriteLine("===== Number Example ======");

Console.WriteLine("Enter a number: ");
try
{
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"The number you entered is : {number}");

}
catch(Exception ex)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input. Enter a valid number!");
    Console.WriteLine($"Exception message: {ex.Message}");

}
finally
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("The Number example finished!");
    Console.ReadLine();

}
// Self thrown exception on purpes

Console.WriteLine("==== Self thrown Exception ====");
Console.WriteLine("Enter a letter a or b");

try
{
    string letter = Console.ReadLine().ToLower().Trim();
    if (letter == "a" || letter == "b")
    {
        Console.WriteLine("Congradulations you have entered a or b");
    }
    else
    {
        // if this is not inside try catch it will break the aplication
        // just like any other exception thrown.

        throw new Exception("That was not letter a nor b! Sorry!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw;
}
finally
{
    Console.WriteLine("Press any key to exit.");
    Console.ReadLine();
}


Console.WriteLine("== Handeling specific exceptions! ===");

try
{
    Console.WriteLine("Enter some characters!");
    char char1 = char.Parse(Console.ReadLine());
    Console.WriteLine($"You have entered the character: {char1}");

    int[] numbers = new int[2] { 1, 2};
    //numbers[2] = 4;

    Console.WriteLine("Please enter 2 numbers");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int dev = num1 / num2;
    Console.WriteLine($"The result is : {dev}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("Error");
    
}
finally
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("Finished the task");
}
#endregion