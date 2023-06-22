namespace Singleton.LazySingleton
{
    public class LazySingletonObject
    {
        private static LazySingletonObject Singleton;
        private readonly Guid Guid;

        // lock object nesnesinin volatile olmasi onemlidir.Bu keyword ana memory'de not null yaptigini garanti eder.
        private static volatile object lockObject = new();
        private LazySingletonObject()
        {
            Guid = Guid.NewGuid();
        }

        //Static nesnelerin ayaga kalkarken olusturulmasi pahali oldugu icin, bu nesne ilk istediginde olusturalim.
        //Burda ki problem ise bu nesnenin thread safe olmamasi yuzunden birden fazla instance olusmasi ihtimali var.
        //public static LazySingletonObject Current
        //{
        //    get
        //    {
        //        Singleton ??= new LazySingletonObject();
        //        return Singleton;
        //    }
        //}

        // Yukaridaki problemi cozmek icin nesneyi locklayabiliriz. Ve aşağıdaki gibi yazabiliriz.
        // Lock islemi pahali bir islemdir.Ve sadece ilk milisaniyelerde gelen birkac thread icin gecerlidir. Burdaki performans problemini cozmek icin
        // Lock islemi double check ile yapilabilir.


        public static LazySingletonObject Current
        {
            get
            {
                if (Singleton is null)
                {
                    lock (lockObject)
                        if (Singleton is null)
                            Singleton = new LazySingletonObject();
                }

                return Singleton;
            }
        }

        public void Print() =>
          Console.WriteLine(Guid.ToString());
    }
}
