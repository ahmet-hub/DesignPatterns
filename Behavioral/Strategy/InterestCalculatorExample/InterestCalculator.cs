public class InterestCalculator
{
    private readonly IInterestCalculationStrategyFactory interestCalculationStrategyFactory;

    public InterestCalculator() => interestCalculationStrategyFactory = new InterestCalculationStrategyFactory();

    public double Calculate(AccountType accountType, double accountBalance) =>
        interestCalculationStrategyFactory
        .Create(accountType)
        .Calculate(accountBalance);
}
public enum AccountType
{
    Current,
    Savings,
    MoneyMarket,
    HighRollerMoneyMarket
}
