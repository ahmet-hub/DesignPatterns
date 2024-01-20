namespace Decorator.ToastExample
{
    public abstract class Topping : IToastable
    {
        private string name;
        protected IToastable toastTopping;
        protected int price;
        private List<Topping> toppings = new List<Topping>();

        public Topping(IToastable toastTopping, int price, string name)
        {
            this.toastTopping = toastTopping;
            toppings.Add(this);
            this.name = name;
            this.price = price;
        }

        public virtual int CalculatePrice()
        {
            return toastTopping.CalculatePrice() + price;
        }

        public virtual List<Topping> GetToppings()
        {
            List<Topping> toppings = toastTopping.GetToppings();
            toppings.Add(this);
            return toppings;
        }

        public string GetName() => name;
        public IToastable GetToastTopping() => toastTopping;

        public int GetPrice() => price;

        public new virtual string ToString() => $"Topping [ name : {name} , price : {price}]";
    }

    public class Cheese : Topping
    {
        public Cheese(IToastable toastTopping, int price, string name) : base(toastTopping, price, name)
        {
        }
    }

    public class Ketchup : Topping
    {
        public Ketchup(IToastable toastTopping, int price, string name) : base(toastTopping, price, name)
        {
        }
    }

    public class Salad : Topping
    {
        public Salad(IToastable toastTopping, int price, string name) : base(toastTopping, price, name)
        {
        }
    }

    public class Sausage : Topping
    {
        public Sausage(IToastable toastTopping, int price, string name) : base(toastTopping, price, name)
        {
        }
    }
}
