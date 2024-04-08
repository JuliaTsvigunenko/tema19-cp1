using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    // Пример 2. Реализация интерфейса IMyInterface, в котором объявлены два метода вывода информации об объектах.

    /// <summary>
    /// Создание интерфейса IMyInterface
    /// с двумя методами
    /// </summary>
    interface IMyInterface
    {
        void Show1();
        void Show2();
    }

    /// <summary>
    /// MyClass - абстрактный класс, в котором
    /// реализуется только метод Show1(), а 
    /// метод Show2() - абстрактный, т.е. не реализуется
    /// </summary>
    abstract class MyClass:IMyInterface
    {
       public void Show1()
        {
            //MyClass.Show1() реализован
            Console.WriteLine("MyClass.Show1() is implemented.");
        }
        /// <summary>
        /// Абстрактный метод Show2()
        /// </summary>
        public abstract void Show2();
    }
   
    /// <summary>
    /// Производный класс - потомок, который наследуется от класса MyClass
    /// </summary>
    class ChildClass : MyClass
    {
        /// <summary>
        /// Переопределенный метод вывода информации об объекте
        /// </summary>
        public override void Show2()
        {
            Console.WriteLine("Child is completing - Show2().");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Изучение интерфейсов. Пример - 2***\n");
            //MyClass is abstract now
            //MyClass myClass = new MyClass();
            MyClass myClass = new ChildClass();
            myClass.Show1();
            myClass.Show2();
            Console.ReadKey();


        }
    }
}
