using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Бегимот", "Мей-кун", "");
            cat.ShowInfo();
            Dog dog = new Dog("Граф", "");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
