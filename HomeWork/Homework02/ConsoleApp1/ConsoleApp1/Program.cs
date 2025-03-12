


#region Task 1

Console.WriteLine("Enter 6 NUMBERS!");

int[] numbers = new int[6];
int sum = 0;

for (int i = 0; i < 6; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out numbers[i]))
    {
        Console.WriteLine("Error: Please enter a valid number!");
        return;
    }

    if (numbers[i] % 2 == 0)
    {
        Console.WriteLine($"{numbers[i]} is even.");
        sum += numbers[i];
    }
}

Console.WriteLine($"Numbers: {string.Join(" ", numbers)}");
Console.WriteLine($"Sum of even numbers: {sum}");
Console.ReadLine();

#endregion

