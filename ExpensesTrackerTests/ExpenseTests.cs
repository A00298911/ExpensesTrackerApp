using Xunit;
using ExpensesTrackerLibrary;

public class ExpenseTests
{
    [Fact]
    public void CanCreateExpense()
    {
        var expense = new Expense
        {
            Id = 1,
            Description = "Groceries",
            Amount = 50.0m,
            Date = DateTime.Now,
            Category = "Food"
        };
        Assert.Equal("Groceries", expense.Description);
    }
}
