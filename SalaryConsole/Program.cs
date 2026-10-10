using SalaryLibrary;

Employee employee = new Employee();
int choice = 0;

while (choice != 7)
{
    Console.WriteLine("========================================");
    Console.WriteLine(" EMPLOYEE SALARY SYSTEM ");
    Console.WriteLine("========================================");

    Console.WriteLine("1. Enter Employee Information.");
    Console.WriteLine("2. Display Employee Information.");
    Console.WriteLine("3. Calculate Gross Salary");
    Console.WriteLine("4. Calculate Tax");
    Console.WriteLine("5. Calculate Net Salary");
    Console.WriteLine("6. Display Salary Grade");
    Console.WriteLine("7. Exit");

    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {

        Console.WriteLine("Enter Employee ID: ");
        employee.EmployeeID = Console.ReadLine() ?? "";

        Console.WriteLine("Enter Employee Name: ");
        employee.EmployeeName = Console.ReadLine() ?? "";

        Console.WriteLine("Enter Basic Salary: ");
        employee.BasicSalary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Allowance: ");
        employee.Allowance = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Deduction: ");
        employee.Deduction = Convert.ToDouble(Console.ReadLine());
    }

    if (choice == 2)
    {
        Console.WriteLine("Employee ID: " + employee.EmployeeID);
        Console.WriteLine("Employee's Name: " + employee.EmployeeName);
        Console.WriteLine("Employee's Basic Salary: " + employee.BasicSalary);
        Console.WriteLine("Employee's Allowance: " + employee.Allowance);
        Console.WriteLine("Employee's Deduction: " + employee.Deduction);

    }

    if (choice == 3)
    {
        double grossSalary = employee.CalculateGrossSalary();

        Console.WriteLine("Calculate Gross Salary: " + grossSalary);
    }

    if (choice == 4)
    {
        double calculateTax = employee.CalculateTax();

        Console.WriteLine("Calculate Tax: " + calculateTax);
    }

    if (choice == 5)
    {
        double calculateNetSalary = employee.CalculateNetSalary();

        Console.WriteLine("Net Salary: " + calculateNetSalary.ToString("N2"));
    }

    if (choice == 6)
    {

        string SalaryGrade = employee.GetSalaryGrade();

        Console.WriteLine("Salary Grade: " + SalaryGrade);
    }
}




