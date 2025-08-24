using System;

namespace AIExpenseReportAutomationAPI.Models;

public class Expense
{
    public int Id { get; set; }                 // Unique identifier
    public DateTime Date { get; set; }          // Report creation date
    public string EmployeeName { get; set; } = string.Empty;
    public string EmployeeId { get; set; } = string.Empty;
    public string Manager { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public decimal Amount { get; set; }         // Expense amount
    public DateTime TransactionDate { get; set; } // Actual date of transaction
    public string Category { get; set; } = string.Empty; // e.g. Travel, Food, etc.
    public string Notes { get; set; } = string.Empty;
}
