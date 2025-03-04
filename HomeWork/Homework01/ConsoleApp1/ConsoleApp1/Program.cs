#region Task 1

//double result = 0;

//Console.WriteLine("Enter the first number:");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter second number:");
//double num2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("What operation would you like to do?");
//char operation = Convert.ToChar(Console.ReadLine());

//if (operation == '+')
//{
//    result = num1 + num2;
//    Console.WriteLine("Result:" + result);
//}
//if (operation == '-')
//{
//    result = num1 - num2;
//    Console.WriteLine("Result:" + result);
//}
//if (operation == '*')
//{
//    result = num1 * num2;
//    Console.WriteLine("Result:" + result);
//}
//if (operation == '/')
//{
//    result = num1 / num2;
//    Console.WriteLine("Result:" + result);
//}
//else
//{
//    Console.WriteLine("Wrong input");
//}
#endregion

#region Task 2

Console.WriteLine("Please enter four numbers");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int number4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Caculating the avarage number...");

int avarageNum = (number1 + number2 + number3 + number4) / 4;

Console.ReadLine();
Console.WriteLine("Calculating...");
Console.ReadLine();
Console.WriteLine($"Your avarage number is {avarageNum}");

#endregion