namespace Decorator.CoffeeExample
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string GetDescription();
    }
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage beverage;
        public Mocha(Beverage beverage) => this.beverage = beverage;
        public override double Cost() => beverage.Cost() + 0.5;
        public override string GetDescription() => beverage.GetDescription() + $", {nameof(Mocha)}";
    }
    public class Milk : CondimentDecorator
    {
        private readonly Beverage beverage;
        public Milk(Beverage beverage) => this.beverage = beverage;

        public override double Cost() => beverage.Cost() + 0.5;
        public override string GetDescription() => beverage.GetDescription() + $", {nameof(Milk)}";
    }
}
