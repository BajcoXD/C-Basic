

//string fullName = Console.ReadLine();

//Console.WriteLine(fullName);

Console.WriteLine("============ DATA CONVERSION ==============");

#region Parse

//int userNumber = int.Parse(Console.ReadLine());
//double userDecimalNumber = double.Parse(Console.ReadLine());

//Console.WriteLine(userDecimalNumber);
//Console.WriteLine(userNumber);



#endregion

#region Convert.To...()

//int userInput = Convert.ToInt32(Console.ReadLine());
//double userDecimal = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine(userInput);
//Console.WriteLine(userDecimal);

#endregion

#region TryParse()
Console.WriteLine("============== TryParse ================");
Console.WriteLine("Please enter number: ");
bool userInput1 = int.TryParse(Console.ReadLine(), out int parsedNumber);
Console.WriteLine("Please enter decimal number: ");
bool userDecimal1 = double.TryParse(Console.ReadLine(), out double parsedDoubleNum);
Console.WriteLine("Please enter boolean value(True OR False): ");
bool userBoolInput = bool.TryParse(Console.ReadLine(), out bool boolNumber);

Console.WriteLine("----------------");
Console.WriteLine(userInput1);
Console.WriteLine(userDecimal1);
Console.WriteLine(userBoolInput);
#endregion

#region if/else

if(userInput1)
{
    Console.WriteLine("The user entered " + parsedNumber);
}
else
{
    Console.WriteLine("Wrong input! Please try again.");
}
if (userBoolInput)
{
    if (boolNumber)
    {
        Console.WriteLine("Yeey! Successful parse of booleans!");
    }
    else
    {
        Console.WriteLine("Wooop! You got false result.");
    }
}
else
{
    Console.WriteLine("Wrong input! Please try again.");
}
#endregion