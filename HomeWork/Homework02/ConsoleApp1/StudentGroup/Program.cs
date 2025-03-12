#region Task 2

string[] studentsG1 = new string[5] {"Viktor", "Filip", "Petko", "Simona", "Stanko"};

string[] studentsG2 = new string[5] { "Viktorija", "Bob", "Darko", "Martin", "Stefan" };

Console.WriteLine("Group of Students (1 OR 2)");

int group = Convert.ToInt32(Console.ReadLine());
if (group == 1)
{
    Console.WriteLine("Writing students...");
    Console.ReadLine();
    for(int i = 0; i < studentsG1.Length; i++)
    {
        Console.WriteLine($"Student: {studentsG1[i]}");
    }
    return;
}
if (group == 2)
{
    Console.WriteLine("Writing students...");
    Console.ReadLine();
    for (int i = 0; i < studentsG2.Length; i++)
    {
        Console.WriteLine($"Student: {studentsG2[i]}");
    }
    return;
}
else
{
    Console.WriteLine("There are only 2 Groups!");
}



#endregion