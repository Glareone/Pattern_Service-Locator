using System;
namespace ServiceLocator
{

    class Program
    {
        static void Main()
        {
            ServiceLocator.RegisterService<IUserService>(typeof(UserService));

            Console.WriteLine(ServiceLocator.Resolve<IUserService>().ReturnSomething());

            Console.ReadLine();
        }
    }




}
