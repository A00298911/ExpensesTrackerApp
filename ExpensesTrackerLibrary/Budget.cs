namespace ExpensesTrackerLibrary
{
    public class Budget
    {
        public int Id { get; set; }
        public decimal Limit { get; set; }
        public required string Category { get; set; }
    }
}
