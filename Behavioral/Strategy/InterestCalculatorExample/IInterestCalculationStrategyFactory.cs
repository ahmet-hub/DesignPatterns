public interface IInterestCalculationStrategyFactory
{
    InterestCalculationStrategy Create(AccountType accountType);
}

public class InterestCalculationStrategyFactory : IInterestCalculationStrategyFactory
{
    public InterestCalculationStrategy Create(AccountType accountType)
    {
        return accountType switch
        {
            AccountType.Current => new CurrentAccountInterestCalculation(),
            AccountType.Savings => new SavingsAccountInterestCalculation(),
            AccountType.MoneyMarket => new MoneyMarketInterestCalculation(),
            AccountType.HighRollerMoneyMarket => new HighRollerMoneyMarketInterestCalculation(),
            _ => new NonInterestCalculation()
        };
    }
}