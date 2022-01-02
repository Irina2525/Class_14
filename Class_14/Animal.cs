using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14
{
    abstract class Animal
    {
        public abstract string Name { get; set; } // абстрактное св-во название животного, св-во без реализации
        public Animal(string name) // конструктор, устанавливающий значение по умолчанию для названия;
        {
            Name = name;
        }
        public abstract void Say(); // абстрактный метод Say(), который выводит звук, который издает животное;
        public void ShowInfo() // неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    class Cat : Animal
    {
        string breed; //порода
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Cat(string name, string breed, string say)
            : base(name)
        {
            this.breed = breed;
        }
        public override void Say()
        {
            Console.WriteLine(breed);
            Console.WriteLine("Мяу!");
            Console.WriteLine();
        }
    }
    class Dog : Animal
    {
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name, string say)
            : base(name)
        {

        }
        public override void Say()
        {
            Console.WriteLine("Гав!");
        }
    }
}