namespace Decorator.ToastExample
{
    public interface IToastable
    {
        public int CalculatePrice();
        List<Topping> GetToppings();
    }
    
    public class ToastBread : IToastable
    {
        private string name;
        protected int price;

        public ToastBread(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public int CalculatePrice()
        {
            return price;
        }

        public List<Topping> GetToppings()
        {
            return new List<Topping>();
        }
    }
}
