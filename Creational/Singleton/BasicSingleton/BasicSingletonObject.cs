namespace Singleton.BasicSingleton
{
    public class BasicSingletonObject
    {
        //Static nesneler uygulama derlenirken ilk olusturulan nesnelerdir. Ve bu dll'in boyutu buyuk olursa bu islem uygulamanin derlenmesini geciktirecektir.
        // Bu istemedigim bir seydir.

        public static BasicSingletonObject Current { get; private set; } = new();
        private readonly Guid Guid;

        private BasicSingletonObject() =>
            Guid = Guid.NewGuid();

        public void Print() =>
            Console.WriteLine(Guid.ToString());
    }
}
