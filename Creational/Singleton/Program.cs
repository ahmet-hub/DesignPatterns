using Singleton.LazySingleton;
using Singleton.MicrosoftLazy;

Console.WriteLine("hello");
int n = 1000;

#region BasicSingletonObject
//for (int i = 0; i < n; i++)
//    BasicSingletonObject.Current.Print();
#endregion

#region LazySingletonObject 

//Parallel.For(0, n, i =>
//{
//    LazySingletonObject.Current.Print();
//});

#endregion

#region MicrosoftLazy 

Parallel.For(0, n, i =>
{
    SingletonObject.Current.Print();
});

#endregion

