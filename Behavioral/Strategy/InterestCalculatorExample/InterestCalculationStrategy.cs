public interface InterestCalculationStrategy
{
    public double Calculate(double accountBalance);
}

#region Concrete 
public class CurrentAccountInterestCalculation : InterestCalculationStrategy
{
    public double Calculate(double accountBalance) => accountBalance * (0.02 / 12);
}

public class SavingsAccountInterestCalculation : InterestCalculationStrategy
{

    public double Calculate(double accountBalance) => accountBalance * (0.04 / 12);
}

public class MoneyMarketInterestCalculation : InterestCalculationStrategy
{
    public double Calculate(double accountBalance) => accountBalance * (0.06 / 12);
}

public class HighRollerMoneyMarketInterestCalculation : InterestCalculationStrategy
{
    public double Calculate(double accountBalance) => accountBalance < 100000.00 ? 0 : accountBalance * (0.075 / 12);
}
public class NonInterestCalculation : InterestCalculationStrategy
{
    public double Calculate(double accountBalance) => 0;
}

#endregion