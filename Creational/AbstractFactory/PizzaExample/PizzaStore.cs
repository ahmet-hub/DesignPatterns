namespace AbstractFactory.PizzaExample
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaType pizzaType)
        {
            var pizza = CreatePizza(pizzaType);

            pizza.Bake();
            pizza.Cut();
            Pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(PizzaType pizzaType);
    }

    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            return pizzaType switch
            {
                PizzaType.NYCheese => new NYStyleCheesePizza(),
                _ => throw new Exception("Not Found")
            };
        }
    }

    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            return pizzaType switch
            {
                PizzaType.ChicagoCheese => new ChicagoStyleCheesePizza(),
                _ => throw new Exception("Not Found")
            };
        }
    }

}
