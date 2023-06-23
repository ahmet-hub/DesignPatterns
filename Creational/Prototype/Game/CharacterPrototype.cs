namespace Prototype.Game
{
    #region Prototype
    public abstract class CharacterPrototype
    {
        public string Name { get; internal set; }

        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
        public abstract void Attack();

        public abstract CharacterPrototype Clone(string name);
    }
    #endregion

    #region Warrior
    public class Warrior : CharacterPrototype
    {
        private readonly List<WarriorSkill> skillList = new();
        public void AddSkill(List<WarriorSkill> skills)
        {
            skillList.AddRange(skills);
        }

        public override void Attack()
        {
            Random r = new();
            var currentSkill = skillList[r.Next(0, skillList.Count)];
            Console.WriteLine($"Warrior attack damage {currentSkill.Power}");
        }


        public override CharacterPrototype Clone(string name)
        {
            var clone = (CharacterPrototype)MemberwiseClone();
            clone.Name = name;
            return clone;
        }
    }
    #endregion

    #region Mage
    public class Mage : CharacterPrototype
    {
        private readonly List<MageSkill> skillList = new();
        public void AddSkill(List<MageSkill> skills)
        {
            skillList.AddRange(skills);
        }

        public override void Attack()
        {
            Random r = new();
            var currentSkill = skillList[r.Next(0, skillList.Count)];
            Console.WriteLine(value: $"Mage attack damage : {currentSkill.Power}");
        }

        public override CharacterPrototype Clone(string name)
        {
            var clone = (CharacterPrototype)MemberwiseClone();
            clone.Name = name;
            return clone;
        }
    } 
    #endregion
}
