namespace Singleton.MicrosoftLazy
{
    public class SingletonObject
    {
        private static readonly Lazy<SingletonObject> lazy = new(() => new SingletonObject(), true);
        public static SingletonObject Current { get { return lazy.Value; } }

        private readonly Guid Guid;
        private SingletonObject() =>
            Guid = Guid.NewGuid();

        public void Print() =>
          Console.WriteLine(Guid.ToString());
    }
}
