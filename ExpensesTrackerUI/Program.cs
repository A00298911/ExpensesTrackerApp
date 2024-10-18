using ExpensesTrackerLibrary;

Console.WriteLine("Welcome to Expenses Tracker!");

// Prompt for the expense description
Console.WriteLine("Enter expense description:");
string? description = Console.ReadLine();

// Validate that the description is not null or empty
while (string.IsNullOrWhiteSpace(description))
{
    Console.WriteLine("Description cannot be empty. Please enter a valid expense description:");
    description = Console.ReadLine();
}

// Prompt for the expense amount
Console.WriteLine("Enter amount:");
decimal amount = 0;
bool isValidAmount = false;

// Loop until a valid decimal amount is entered
while (!isValidAmount)
{
    string? amountInput = Console.ReadLine();
    if (decimal.TryParse(amountInput, out amount) && amount > 0)
    {
        isValidAmount = true;
    }
    else
    {
        Console.WriteLine("Invalid amount. Please enter a valid number:");
    }
}

// Create a new expense with the provided data
Expense newExpense = new Expense
{
    Description = description,
    Amount = amount,
    Date = DateTime.Now,
    Category = "Miscellaneous"
};

// Display confirmation message
Console.WriteLine($"Expense '{newExpense.Description}' of amount {newExpense.Amount} added successfully.");
