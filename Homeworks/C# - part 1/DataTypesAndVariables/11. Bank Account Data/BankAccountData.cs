using System;

public class BankAccountData
{
    static void Main(string[] args)
    {
        //Description

        //A bank account has a holder name (first name, middle name and last name),
        //available amount of money(balance), bank name, IBAN, 3 credit card numbers
        //associated with the account.Declare the variables needed to keep the information
        //for a single bank account using the appropriate data types and descriptive names.

        string firstName = "Ivaylo";
        string middleName = "Valeriev";
        string lastName = "Kostov";
        decimal balance = 1000m;
        string bank = "ITBank";
        uint iban = 123456;
        uint creditCardA = 123;
        uint creditCardB = 456;
        uint creditCardC = 789;
    }
}
