Console.Write("Enter your birthdate (YYYY-MM-DD): ");
string input = Console.ReadLine();

if (DateTime.TryParse(input, out DateTime birthDate)) // Validate input
{
    int age = AgeCalculator(birthDate); // Call the method
    Console.WriteLine($"You are {age} years old.");
}
else
{
    Console.WriteLine("Invalid date format. Please use YYYY-MM-DD.");
}

Console.ReadLine();
    

    static int AgeCalculator(DateTime birthDate)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthDate.Year;

    // Adjust age if birthday hasn't occurred yet this year
    if (birthDate.Date > today.AddYears(-age))
    {
        age--;
    }

    return age;
}