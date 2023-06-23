namespace AbstractFactory.Game
{
    public abstract class UnitFactory
    {
        public abstract Infantry CreateInfantry();
        public abstract Cavalry CreateCavalry();
        public abstract Archer CreateArcher();
    }

    #region Archers
    public abstract class Infantry
    {
        public abstract void Attack();
    }

    public abstract class Cavalry
    {
        public abstract void Attack();
    }

    public abstract class Archer
    {
        public abstract void Attack();
    } 
    #endregion

}
