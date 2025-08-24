using System;

namespace AIExpenseReportAutomationAPI.Models;

public class Expense
{
    public Guid Id { get; set; }                 // Unique identifier
    public DateTime Date { get; set; }          // Report creation date
    public decimal Amount { get; set; }         // Expense amount
    public DateTime TransactionDate { get; set; } // Actual date of transaction
    public Guid EmployeeId { get; set; }        // Foreign key to Employee
    public Employee? Employee { get; set; }     // Navigation property to Employee
    public Guid CategoryId { get; set; }        // Foreign key to Category
    public Category? Category { get; set; }     // Navigation property to Category  
    public Guid DepartmentId { get; set; }      // Foreign key to Department
    public Department? Department { get; set; } // Navigation property to Department
    public string Notes { get; set; } = string.Empty;
}
