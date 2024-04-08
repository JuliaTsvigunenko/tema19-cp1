using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Пример 1. Реализация одного интерфейса IMyInterface в производном классе MyClass.

    /// <summary>
    /// Интерфейс
    /// </summary>
    interface IMyInterface
    {
        /// <summary>
        /// Нереализованный метод вывода информации об объекте
        /// </summary>
        void Show();
    }
    /// <summary>
    /// Класс, в котором реализуется интерфейс 
    /// </summary>
    class MyClass:IMyInterface
    {
        /// <summary>
        /// MyClass.Show() реализован
        /// </summary>
        public void Show()
        {
            Console.WriteLine("MyClass.Show() is implemented (реализован).");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Изучение интерфейсов. Пример - 1***\n");
            MyClass myClass = new MyClass();
            myClass.Show();
            Console.ReadKey();











        }
    }
}
