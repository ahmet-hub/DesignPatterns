namespace AbstractFactory.PizzaExample
{
    public abstract class Pizza
    {
        public Pizza(string name)
        {
            Console.WriteLine($"Preparing {name}");
            Console.WriteLine();
        }
        public virtual void Bake() => Console.WriteLine("Bake for 25 minutes at 350");
        public virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices");
        public static void Box() => Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza() : base(nameof(ChicagoStyleCheesePizza)) { }
    }

    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza() : base(nameof(NYStyleCheesePizza)) { }

        public override void Bake() => Console.WriteLine("Bake for 30 minutes at 350");
    }
}
