using Prototype.Game;

#region AccountExample
//var defaultAccount = new Account(1, 100, false, false, false, new Customer { Id = 1, FirstName = "Ahmet", LastName = "Yardimci" });


//var activeAccount = (Account)defaultAccount.Clone();
//activeAccount.SetOwner(new Customer { Id = 2, FirstName = "Ali", LastName = "LastName" });
//activeAccount.SetHasDeposit(true);
//activeAccount.SetHasDeposit(false);
//activeAccount.SetHasDeposit(true);

//var lockedAccount = (Account)defaultAccount.Clone();
//lockedAccount.SetIsLocked(true);


//Console.WriteLine(lockedAccount.HasWithdraw);

#endregion

#region MiniGame :)

var warriorSkils = new List<WarriorSkill>
{
    new WarriorSkill { Level = 1, Power = 10 },
    new WarriorSkill { Level = 2, Power = 20 },
    new WarriorSkill { Level = 3, Power = 30 },
    new WarriorSkill { Level = 4, Power = 40 },
    new WarriorSkill { Level = 5, Power = 50 },
};

var mageSkilss = new List<MageSkill>
{
    new MageSkill { Level = 1, Power = 10 },
    new MageSkill { Level = 2, Power = 20 },
    new MageSkill { Level = 3, Power = 30 },
    new MageSkill { Level = 4, Power = 40 },
    new MageSkill { Level = 5, Power = 50 },
};

var warriorPrototype = new Warrior();

warriorPrototype.AddSkill(warriorSkils);

var magePrototype = new Mage();

magePrototype.AddSkill(mageSkilss);

var clonedWarrior = warriorPrototype.Clone("Savasci");

var clonedMage = magePrototype.Clone("Savasci");


for (int i = 0; i < 5; i++)
{
    clonedWarrior.Attack();
    clonedMage.Attack();
}

#endregion
