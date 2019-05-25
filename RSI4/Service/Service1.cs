using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public void Funkcja1(string s1)
        {
            Console.WriteLine("...{ 0} fkcja1 - start");
            Thread.Sleep(3000);
            Console.WriteLine("...{ 0} fkcja1 - stop");
            return;
        }

        public void Funkcja2(string s1)
        {
            Console.WriteLine("...{ 0} fkcja2 - start");
            Thread.Sleep(3000);
            Console.WriteLine("...{ 0} fkcja2 - stop");            
            return;
        }

      
    }
}
