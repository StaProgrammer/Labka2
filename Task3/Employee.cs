using System;

public class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void CalculateSalaryAndTax(string position, int experience)
    {
        double baseSalary = 0.0;
        double taxRate = 0.0;

        switch (position.ToLower())
        {
            case "security":
                baseSalary = 15700;
                taxRate = experience < 2 ? 0.11 : 0.2;
                break;

            case "director":
                baseSalary = 37299;
                taxRate = experience < 4 ? 0.3 : 0.19;
                break;

            case "programmer":
                baseSalary = 29777;
                taxRate = experience < 7 ? 0.22 : 0.19;
                break;

            default:
                Console.WriteLine("Неправильна посада!");
                return;
        }

        double tax = baseSalary * taxRate;
        double netSalary = baseSalary - tax;

        Console.WriteLine("Інформація про співробітника:");
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {baseSalary} грн");
        Console.WriteLine($"Податковий збір ({taxRate * 100}%): {tax} гривень");
        Console.WriteLine($"Зарплата при сплаті податку: {netSalary} гривень");
    }

    static void Main()
    {
        Console.WriteLine("Введіть прізвище співробітника:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Введіть ім'я співробітника:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Введіть посаду співробітника (security, director, programmer):");
        string position = Console.ReadLine();

        Console.WriteLine("Введіть стаж співробітника:");
        int experience = int.Parse(Console.ReadLine());

        Employee employee = new Employee(lastName, firstName);
        employee.CalculateSalaryAndTax(position, experience);
    }
}