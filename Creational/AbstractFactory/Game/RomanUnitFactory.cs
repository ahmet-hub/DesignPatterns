namespace AbstractFactory.Game
{
    public class RomanUnitFactory : UnitFactory
    {
        public override Archer CreateArcher()
        {
            return new RomanArcher();
        }

        public override Cavalry CreateCavalry()
        {
            return new RomanCavalry();
        }

        public override Infantry CreateInfantry()
        {
           return new RomanInfantry();
        }
    }

    #region Archers
    public class RomanArcher : Archer
    {
        public override void Attack()
        {
            Console.WriteLine("Roman archer attacks with bows.");
        }
    }

    public class RomanCavalry : Cavalry
    {
        public override void Attack()
        {
            Console.WriteLine("Roman cavalry attacks with spears.");
        }
    }

    public class RomanInfantry : Infantry
    {
        public override void Attack()
        {
            Console.WriteLine("Roman infantry attacks with swords.");
        }
    } 
    #endregion

}
