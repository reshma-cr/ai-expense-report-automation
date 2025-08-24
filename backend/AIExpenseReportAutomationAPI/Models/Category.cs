using System;

namespace AIExpenseReportAutomationAPI.Models;

public class Category
{
    public Guid Id { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public List<Expense> Expenses { get; set; } = new List<Expense>();
}
