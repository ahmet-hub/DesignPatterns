namespace Decorator.CoffeeExample
{
    public abstract class Beverage
    {
        protected string Description { get; set; } = "Unknow coffee";
        public virtual string GetDescription() => Description;
        public abstract double Cost();
    }
    public class HouseBlend : Beverage
    {
        public HouseBlend() => Description = nameof(HouseBlend);
        public override double Cost() => 1.99;
    }
    public class Espresso : Beverage
    {
        public Espresso() => Description = nameof(Espresso);
        public override double Cost() => 2.99;
    }
}
