
#region variables and data types
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("=============== Variables and data types ==================");
int testVariables = 0;
int number = 5;
int studentCount = 19;

int veryBigNumber1 = -2147483648;

// Cannot declare int variable with value lower than -2147483648
// or bigger than 2147483648. C# will treat that as 'long' type
//int veryBigNumber = -21474836482;

long veryBigNumber2 = -21474836482232111;


// This will throw an error becouse testVariable is not initialized
// you can add deafult value zero
//Console.WriteLine(testVariables);

Console.WriteLine(testVariables);
Console.WriteLine(number);
Console.WriteLine(studentCount);
Console.WriteLine(veryBigNumber1);
Console.WriteLine(veryBigNumber2);


Console.WriteLine("----------------------------------------------------");
double price = 19.4;

decimal tax = 1.4m;

float weight = 70.4f;

char specialCharacter = '!';

string firstName = "Viktor";
string lastName = "Stojanovski";

bool isThursday = true;
bool isRaining = true;

Console.WriteLine(price);
Console.WriteLine(tax);
Console.WriteLine(weight);
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine(lastName);
Console.WriteLine(isThursday);
Console.WriteLine(isRaining);
#endregion

#region Operators
Console.WriteLine("========================== Operators ========================");

int a = 10;
int b = 15;
double c = 10;
double d = 15;

int sum = a + b;
int difference = a - b;
int product = a * b;
double division = c / d;
int modulus = a % b;

Console.WriteLine(sum);
Console.WriteLine(difference);
Console.WriteLine(product);
Console.WriteLine(division);
Console.WriteLine(modulus);
#endregion

#region Deafult values

Console.WriteLine("================= Deafoult Values =================");

int someNumber = default; // 0
string someText = default; // Null
bool someBoolean = default; // false
double someDouble = default; // 0

Console.WriteLine(someNumber);
Console.WriteLine(someText);
Console.WriteLine(someBoolean);
Console.WriteLine(someDouble);

#endregion

#region exercise
Console.WriteLine("=============== EXERCISES =================");

Console.WriteLine("----------Exercise 1----------");
double num1 = 20;
double num2 = 15;

double devided = num1 / num2;

int num11 = 20;
int num22 = 15;

int result = num11 / num22;

Console.WriteLine(result);
Console.WriteLine(devided);

Console.WriteLine("---------- Exercise 2 -----------");

string eden = "eden";
string dva = "dva";

string broeviteDva = eden + " " + dva;

string nine = "9";
string three = "3";

string nineThree = nine + three;

Console.WriteLine(nineThree);
Console.WriteLine(broeviteDva);

Console.WriteLine("------------ Exercise 3 -----------");

string name = " Viktor ";

int age = 19;

string result2 = name + age;

Console.WriteLine(result2);
Console.WriteLine(name + age);

Console.WriteLine("----------- Exercise 4 -----------");

int m = 5;
int n = 102;
int sms = n / m;

Console.WriteLine(sms);

#endregion
