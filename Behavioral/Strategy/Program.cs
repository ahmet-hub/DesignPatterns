
InterestCalculator interestCalculator = new();

Console.WriteLine($"Account Type : {AccountType.Current}, Interest Rate               : {interestCalculator.Calculate(AccountType.Current, 100)}");
Console.WriteLine($"Account Type : {AccountType.Savings}, Interest Rate               : {interestCalculator.Calculate(AccountType.Savings, 100)}");
Console.WriteLine($"Account Type : {AccountType.MoneyMarket}, Interest Rate           : {interestCalculator.Calculate(AccountType.MoneyMarket, 100)}");
Console.WriteLine($"Account Type : {AccountType.HighRollerMoneyMarket}, Interest Rate : {interestCalculator.Calculate(AccountType.HighRollerMoneyMarket, 100)}");