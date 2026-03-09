// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
//Mettre en correspondance une valeur
string bankRecords = """
    DEPOSIT,   10000, Initial balance
    DEPOSIT,     500, regular deposit
    WITHDRAWAL, 1000, rent
    DEPOSIT,    2000, freelance payment
    WITHDRAWAL,  300, groceries
    DEPOSIT,     700, gift from friend
    WITHDRAWAL,  150, utility bill
    DEPOSIT,    1200, tax refund
    WITHDRAWAL,  500, car maintenance
    DEPOSIT,     400, cashback reward
    WITHDRAWAL,  250, dining out
    DEPOSIT,    3000, bonus payment
    WITHDRAWAL,  800, loan repayment
    DEPOSIT,     600, stock dividends
    WITHDRAWAL,  100, subscription fee
    DEPOSIT,    1500, side hustle income
    WITHDRAWAL,  200, fuel expenses
    DEPOSIT,     900, refund from store
    WITHDRAWAL,  350, shopping
    DEPOSIT,    2500, project milestone payment
    WITHDRAWAL,  400, entertainment
    """;

double currentBalance = 0.0;
var reader = new StringReader(bankRecords);

string? line;
while ((line = reader.ReadLine()) is not null)
{
    if (string.IsNullOrWhiteSpace(line)) continue;
    // Split the line based on comma delimiter and trim each part
    string[] parts = line.Split(',');

    string? transactionType = parts[0]?.Trim();
    if (double.TryParse(parts[1].Trim(), out double amount))
    {
        // Update the balance based on transaction type
        if (transactionType?.ToUpper() is "DEPOSIT")
            currentBalance += amount;
        else if (transactionType?.ToUpper() is "WITHDRAWAL")
            currentBalance -= amount;

        Console.WriteLine($"{line.Trim()} => Parsed Amount: {amount}, New Balance: {currentBalance}");
    }
}

static IEnumerable<(TransactionType type, double amount)> TransactionRecords(string inputText)
{
    var reader = new StringReader(inputText);
    string? line;
    while ((line = reader.ReadLine()) is not null)
    {
        string[] parts = line.Split(',');

        string? transactionType = parts[0]?.Trim();
        if (double.TryParse(parts[1].Trim(), out double amount))
        {
            // Update the balance based on transaction type
            if (transactionType?.ToUpper() is "DEPOSIT")
                yield return (TransactionType.Deposit, amount);
            else if (transactionType?.ToUpper() is "WITHDRAWAL")
                yield return (TransactionType.Withdrawal, amount);
        }
        else
        {
            yield return (TransactionType.Invalid, 0.0);
        }
    }
}

currentBalance = 0.0;

foreach (var transaction in TransactionRecords(bankRecords))
{
    if (transaction.type == TransactionType.Deposit)
        currentBalance += transaction.amount;
    else if (transaction.type == TransactionType.Withdrawal)
        currentBalance -= transaction.amount;
    Console.WriteLine($"{transaction.type} => Parsed Amount: {transaction.amount}, New Balance: {currentBalance}");
}

//Correspondances d’énumération
public enum TransactionType
{
    Deposit,
    Withdrawal,
    Invalid
}
*/

/*
//Correspondances exhaustives sans switch 
int n = GetNumber();

if (n < 10)
    Console.WriteLine("n is less than 10");
else if (n < 20)
    Console.WriteLine("n is less than 20");
else
    Console.WriteLine("n is greater than or equal to 20");

int GetNumber()
{
    return 15;
}
*/

/*
//Correspondances exhaustives avec switch 
int n = GetNumber();

string result = n switch
{
    < 10 => "n is less than 10",
    < 20 => "n is less than 20",
    _ => "n is greater than or equal to 20"
};

Console.WriteLine(result);

int GetNumber()
{
    return 15;
}
*/


//Modèles de type
// Types de transactions
public record Deposit(double Amount, string Description);
public record Withdrawal(double Amount, string Description);

class Program
{
    static void Main()
    {
        string bankRecords =
@"DEPOSIT,1000,Salary
WITHDRAWAL,200,Groceries
DEPOSIT,500,Freelance work
WITHDRAWAL,100,Restaurant";

        double currentBalance = 0.0;

        foreach (var transaction in GetTransactionRecords(bankRecords))
        {
            currentBalance += transaction switch
            {
                Deposit d => d.Amount,
                Withdrawal w => -w.Amount,
                _ => 0.0
            };

            Console.WriteLine($"{transaction} => New Balance: {currentBalance}");
        }
    }

    // Lecture des transactions depuis le texte
    static IEnumerable<object?> GetTransactionRecords(string inputText)
    {
        var reader = new StringReader(inputText);
        string? line;

        while ((line = reader.ReadLine()) is not null)
        {
            string[] parts = line.Split(',');

            string? transactionType = parts[0]?.Trim();

            if (double.TryParse(parts[1].Trim(), out double amount))
            {
                if (transactionType?.ToUpper() == "DEPOSIT")
                    yield return new Deposit(amount, parts[2]);

                else if (transactionType?.ToUpper() == "WITHDRAWAL")
                    yield return new Withdrawal(amount, parts[2]);
            }
        }
    }
}