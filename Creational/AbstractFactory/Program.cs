
using AbstractFactory.Game;

var romanFactory = new RomanUnitFactory();
var ottomanFactory = new OttomanUnitFactory();

var romanArcher = romanFactory.CreateArcher();
romanArcher.Attack();

var ottomanInfantry = ottomanFactory.CreateInfantry();
ottomanInfantry.Attack();