namespace Prototype.AccountExample
{
    public class Account : ICloneable
    {
        public Account(int id, decimal balance, bool hasWithdraw, bool hasDeposit, bool isLocked, Customer customer)
        {
            Id = id;
            Balance = balance;
            HasWithdraw = hasWithdraw;
            HasDeposit = hasDeposit;
            IsLocked = isLocked;
            Customer = customer;
        }

        public int Id { get; private set; }
        public decimal Balance { get; private set; }
        public bool HasWithdraw { get; private set; }
        public bool HasDeposit { get; private set; }
        public bool IsLocked { get; private set; }
        public Customer Customer { get; private set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void SetHasDeposit(bool v) => HasDeposit = v;
        public void SetHasWithdraw(bool v) => HasWithdraw = v;
        public void SetIsLocked(bool v) => IsLocked = v;

        public void SetOwner(Customer customer) => Customer = customer;

    }
}


public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
