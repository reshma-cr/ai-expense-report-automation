using System;

namespace AIExpenseReportAutomationAPI.Models;

public class Employee
{
    public Guid Id { get; set; }
    public int EmployeeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public Guid DepartmentId { get; set; }
    public Department? Department { get; set; }
    public Guid ManagerId { get; set; }
    public Employee? Manager { get; set; }
    public List<Employee> Reportees { get; set; } = new List<Employee>();
    public List<Expense> Expenses { get; set; } = new List<Expense>();
}
