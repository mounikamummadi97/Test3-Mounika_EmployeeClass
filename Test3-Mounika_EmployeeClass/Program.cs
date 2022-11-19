// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Test3_Mounika_EmployeeClassLibrary;

SalaryCalculation objSalaryCalculation = new SalaryCalculation();
Console.WriteLine("Enter Employee Details.....");
Console.WriteLine("Enter Employee Id");
objSalaryCalculation.EmployeeId = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Employee Name");
objSalaryCalculation.EmployeeName = Console.ReadLine();

Console.WriteLine("Enter Employee Salary");
objSalaryCalculation.EmployeeSalary = int.Parse(Console.ReadLine());

objSalaryCalculation.DisplayEmployeeDetails();
objSalaryCalculation.TaxCalculation();
objSalaryCalculation.DisplaySalaryDetails();