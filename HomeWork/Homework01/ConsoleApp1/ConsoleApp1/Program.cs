#region Task 1

double result = 0;

Console.WriteLine("Enter the first number:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number:");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What operation would you like to do?");
char operation = Convert.ToChar(Console.ReadLine());

if (operation == '+')
{
    result = num1 + num2;
    Console.WriteLine("Result:" + result);
}
if (operation == '-')
{
    result = num1 - num2;
    Console.WriteLine("Result:" + result);
}
if (operation == '*')
{
    result = num1 * num2;
    Console.WriteLine("Result:" + result);
}
if (operation == '/')
{
    result = num1 / num2;
    Console.WriteLine("Result:" + result);
}
else
{
    Console.WriteLine("Wrong input");
}
#endregion