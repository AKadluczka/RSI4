using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KlientProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            SerwisClient serwisClient
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            
            Console.WriteLine("wywolanie fkcj1");
            serwisClient.Funkcja("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("kontynuacja fkcj1");

            Console.WriteLine("wywolanie fkcj2");
            serwisClient.Funkcja("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("kontynuacja fkcj2");

            Console.WriteLine("wywolanie fkcj1");
            serwisClient.Funkcja("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("kontynuacja fkcj1");
            serwisClient.close();
            Console.Write("KONIEC KLIENT1");

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
