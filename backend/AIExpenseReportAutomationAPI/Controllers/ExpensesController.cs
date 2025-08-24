using AIExpenseReportAutomationAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AIExpenseReportAutomationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public ExpensesController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetAllExpenses()
        {
            var expenses = _context.Expenses.ToList();
            return Ok(expenses);
        }

        [HttpGet("{id}")]
        public IActionResult GetExpenseById(int id)
        {
            var expense = _context.Expenses.Find(id);
            if (expense == null)
            {
                return NotFound();
            }
            return Ok(expense);
        }
    }
}
