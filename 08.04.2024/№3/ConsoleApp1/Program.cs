using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Пример 3. Реализация концепции множественного наследования(класс реализует два интерфейса).

    interface IMyInterfaceA
    {
        void ShowA();
    }
    interface IMyInterfaceB
    {
        void ShowB();
    }

    class MyClass : IMyInterfaceA, IMyInterfaceB
    {
        public void ShowA()
        {
            Console.WriteLine("MyClass.ShowA() is completed.");
        }
        public void ShowB()
        {
            Console.WriteLine("MyClass.ShowB() is completed.");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Изучение интерфейсов. Пример - 3***\n");
            MyClass myClass = new MyClass();
            myClass.ShowA();
            myClass.ShowA();
            Console.ReadKey();










        }
    }
}
