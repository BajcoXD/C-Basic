
using System.Security.Claims;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("================== ARRAYS ===============");
Console.ResetColor();

Console.WriteLine("\n============== Creating an array ============\n");

// ====>Array Type Syntax
// eg. array of integers => int[]
// eg. array of strings => strings[]
// eg. array of double => double[]
// eg, array of characters => char[]

// 1) Declaring and inirializing an array

int[] numbers = new int[] { 11, 22, 24, 32, 12, -3 };
Console.WriteLine(numbers[0]); // 11
Console.WriteLine(numbers[4]); // 12

Console.WriteLine("===========  Declaring an array ============");
//2) Declaring an array

string[] students = new string[3];
students[0] = "Viktor";
students[1] = "Marija";
students[2] = "Filip";

//students[3] = "Darko";
Console.WriteLine(students[0]);
Console.WriteLine(students[1]);
Console.WriteLine(students[2]);
//Console.WriteLine(students[3]);

// ERROR STUDENT [3]


Console.WriteLine("=========== ARRAY METHODS =============");

// 
Console.WriteLine("Numbers array lenght is " + numbers.Length);

// === Sorting an Arrray
Array.Sort(numbers);
Console.WriteLine(numbers[1]);

// Searching for an element

int indexOfOne = Array.IndexOf(numbers, -3);
Console.WriteLine($"The index of -3 is {indexOfOne}");
Console.WriteLine(numbers[indexOfOne]);

int indexOfSeven = Array.IndexOf(numbers, 7);
Console.WriteLine($"The index of 7 is {indexOfSeven}");
//

Console.WriteLine("\n============== Adding new items ===============\n");
// Arrays have a fixed size, so we cant add elements direcly to them
// instead, we use resizing
string[] newStudent = new string[3];
newStudent[0] = "Bob";
newStudent[1] = "John";
newStudent[2] = "Vic";

//Array.Resize(ref newStudent, 4);
Array.Resize(ref newStudent, newStudent.Length + 1);
newStudent[3] = "Dare";
Console.WriteLine(newStudent[3]);

Console.ReadLine();