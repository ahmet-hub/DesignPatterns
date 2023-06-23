namespace AbstractFactory.Game
{
    public class OttomanUnitFactory : UnitFactory
    {
        public override Archer CreateArcher()
        {
            return new OttomanArcher();
        }

        public override Cavalry CreateCavalry()
        {
            return new OttomanCavalry();
        }

        public override Infantry CreateInfantry()
        {
            return new OttomanInfantry();
        }
    }


    #region Archers
    public class OttomanArcher : Archer
    {
        public override void Attack()
        {
            Console.WriteLine("Ottoman archer attacks with bows.");
        }
    }

    public class OttomanCavalry : Cavalry
    {
        public override void Attack()
        {
            Console.WriteLine("Ottoman cavalry attacks with spears.");
        }
    }

    public class OttomanInfantry : Infantry
    {
        public override void Attack()
        {
            Console.WriteLine("Ottoman infantry attacks with spears.");
        }
    }
    #endregion

}
