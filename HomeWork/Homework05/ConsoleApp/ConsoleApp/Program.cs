public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public virtual double GetSalary()
    {
        return Salary;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}");
    }
}

// Contractor class (inherits Employee)
public class Contractor : Employee
{
    public Contractor(string firstName, string lastName, double salary)
        : base(firstName, lastName, salary) { }
}

// Manager class (inherits Employee)
public class Manager : Employee
{
    public Manager(string firstName, string lastName, double salary)
        : base(firstName, lastName, salary) { }
}

// SalesPerson class (inherits Employee)
public class SalesPerson : Employee
{
    public SalesPerson(string firstName, string lastName, double salary)
        : base(firstName, lastName, salary) { }
}

// CEO class (inherits Employee)
public class CEO : Employee
{
    public Employee[] Employees { get; set; }
    public int Shares { get; set; }
    private double SharesPrice { get; set; }

    public CEO(string firstName, string lastName, double salary, int shares, Employee[] employees)
        : base(firstName, lastName, salary)
    {
        Shares = shares;
        Employees = employees;
        SharesPrice = 0; // Default value
    }

    public void AddSharesPrice(double newPrice)
    {
        SharesPrice = newPrice;
    }

    public override double GetSalary()
    {
        return Salary + (Shares * SharesPrice);
    }

    public void PrintEmployees()
    {
        Console.WriteLine("\nEmployees:");
        foreach (var employee in Employees)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an array of employees (2 Contractors, 2 Managers, 1 SalesPerson)
        Employee[] companyEmployees = {
                new Contractor("Bob", "Bobert", 1000),
                new Contractor("Rick", "Rickert", 1100),
                new Manager("Mona", "Monalisa", 2000),
                new Manager("Igor", "Igorsky", 2100),
                new SalesPerson("Lea", "Leova", 1800)
            };

        // Create CEO instance
        CEO ceo = new CEO("Ron", "Ronsky", 1500, 70, companyEmployees);

        // Update shares price
        ceo.AddSharesPrice(20);

        // Print CEO Info
        Console.WriteLine("CEO:");
        ceo.PrintInfo();

        // Print CEO salary
        Console.WriteLine($"\nSalary of CEO is: {ceo.GetSalary()}");

        // Print all employees
        ceo.PrintEmployees();
    }
}