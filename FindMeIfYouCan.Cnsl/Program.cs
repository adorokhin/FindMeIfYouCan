using FindMeIfYouCan.Lib;
using System;

//C:\Users\AlexD>set | findstr "\<Path\>"


namespace FindMeIfYouCan.Cnsl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SecretClass.password);
            Console.ReadLine();
        }
    }
}
