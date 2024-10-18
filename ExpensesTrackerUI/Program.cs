using ExpensesTrackerLibrary;

Console.WriteLine("Welcome to Expenses Tracker!");
Console.WriteLine("Enter expense description:");
string description = Console.ReadLine();

Console.WriteLine("Enter amount:");
decimal amount = Convert.ToDecimal(Console.ReadLine());

Expense newExpense = new Expense
{
    Description = description,
    Amount = amount,
    Date = DateTime.Now,
    Category = "Miscellaneous"
};

Console.WriteLine($"Expense '{newExpense.Description}' of amount {newExpense.Amount} added successfully.");
