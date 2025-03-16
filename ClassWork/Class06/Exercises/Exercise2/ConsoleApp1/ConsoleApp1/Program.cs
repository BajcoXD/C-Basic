using ConsoleApp1.Models;
using System;
using System.Collections.Generic;

static class Program
{
    static List<User> users = new List<User>
    {
        new User("Alice", "password123", new string[] { "Hello, Alice!", "Welcome to the system." }),
        new User("Bob", "securePass", new string[] { "Hey Bob!", "You have a new notification." }),
        new User("Charlie", "mySecret", new string[] { "Good morning, Charlie!", "Your profile was updated." })
    };

    static void Main()
    {
        ShowMenu();
    }

    static void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1 - Login");
            Console.WriteLine("2 - Register");
            Console.WriteLine("3 - Exit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Login();
                    break;
                case "2":
                    Register();
                    break;
                case "3":
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void Login()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        foreach (User user in users)
        {
            if (user.Username == username && user.Password == password)
            {
                Console.WriteLine($"Login successful! Welcome, {user.Username}.");
                Console.WriteLine("Your messages:");
                foreach (string message in user.Messages)
                {
                    Console.WriteLine($"- {message}");
                }
                return;
            }
        }

        Console.WriteLine("Invalid username or password. Try again.");
    }

    static void Register()
    {
        Console.Write("Enter a new username: ");
        string username = Console.ReadLine();

        // Check if username already exists
        foreach (User user in users)
        {
            if (user.Username == username)
            {
                Console.WriteLine("Username already taken. Try again.");
                return;
            }
        }

        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        // Create a new user with default messages
        User newUser = new User(username, password, new string[] { "Welcome!", "Thank you for registering!" });

        // Add new user to the list
        users.Add(newUser);
        Console.WriteLine("Registration successful! You can now log in.");
    }
}
