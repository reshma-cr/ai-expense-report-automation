using System;

namespace AIExpenseReportAutomationAPI.Models;

public class Department
{
    public Guid Id { get; set; }
    public string DepartmentName { get; set; } = string.Empty;
    public List<Employee> Employees { get; set; } = new List<Employee>();
    public List<Expense> Expenses { get; set; } = new List<Expense>();
}
