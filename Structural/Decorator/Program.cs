
using Decorator.CoffeeExample;
using Decorator.ToastExample;

Beverage beverage = new Espresso();

beverage.Cost();

beverage = new Mocha(beverage);
beverage = new Mocha(beverage);
beverage = new Milk(beverage);
Console.WriteLine(beverage.GetDescription());
Console.WriteLine(beverage.Cost());


//IToastable ayvalikToast = new ToastBread("Toast Bread", 5);

//ayvalikToast = new Cheese(ayvalikToast, 3, "Cheddar cheese");
//ayvalikToast = new Sausage(ayvalikToast, 3, "Sausage");

//Console.WriteLine(ayvalikToast.CalculatePrice());
//foreach (var item in ayvalikToast.GetToppings())
//{
//    Console.WriteLine(item.ToString());
//}