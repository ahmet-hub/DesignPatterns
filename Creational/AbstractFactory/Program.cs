using AbstractFactory.PizzaExample;

//var romanFactory = new RomanUnitFactory();
//var ottomanFactory = new OttomanUnitFactory();
//var romanArcher = romanFactory.CreateArcher();
//romanArcher.Attack();

//var ottomanInfantry = ottomanFactory.CreateInfantry();
//ottomanInfantry.Attack();



Application app = new();
app.OrderPizza(PizzaType.NYCheese);
Console.WriteLine("-----------------------------");
app.OrderPizza(PizzaType.ChicagoCheese);
