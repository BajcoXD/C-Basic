#region Task 3

string[] names = new string[0]; 
int count = 0; 

while (true)
{
    Console.Write("Enter a name: ");
    string name = Console.ReadLine();

    // Increase array size by 1 and add the new name
    Array.Resize(ref names, count + 1);
    names[count] = name;
    count++;

    Console.Write("Do you want to enter another name? (Y/N): ");
    string choice = Console.ReadLine().Trim().ToUpper();

    if (choice == "N")
    {
        break; // Stop if the user enters 'N'
    }
}

Console.WriteLine("\nNames entered:");
Console.WriteLine(string.Join(", ", names));

#endregion