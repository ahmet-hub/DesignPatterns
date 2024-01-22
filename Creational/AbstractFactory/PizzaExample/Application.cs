namespace AbstractFactory.PizzaExample
{
    public class Application
    {
        public Pizza OrderPizza(PizzaType type)
        {
            var store = GetStoreType(type);

            return PizzaStoreFactory
                .Create(store)
                .OrderPizza(type);
        }

        private StoreType GetStoreType(PizzaType pizzaType)
        {
            return pizzaType switch
            {
                PizzaType.NYCheese => StoreType.Ny,
                PizzaType.ChicagoCheese => StoreType.Chicago,
                _ => throw new ArgumentException("Invalid PizzaType"),
            };
        }
    }

    public class PizzaStoreFactory
    {
        public static PizzaStore Create(StoreType storeType)
        {
            return storeType switch
            {
                StoreType.Ny => new NYPizzaStore(),
                StoreType.Chicago => new ChicagoPizzaStore(),
                _ => throw new Exception("Not Found")
            };
        }
    }
}
