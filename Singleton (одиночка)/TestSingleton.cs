using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton__одиночка_
{
    class TestSingleton //реализация одиночки
    {
        private TestSingleton() { }//Приватный конструктор для создания экземпляра класса

        private static TestSingleton _instance;// указатель на экземпляр класса

        [MethodImpl(MethodImplOptions.Synchronized)]//Чтобы при использовании нескольких потоков случайно не создался еще один экземпляр класса
        public static TestSingleton getInstance()//функция создания экземпляра класса, с проверкой не существует ли он
        {
            if(_instance == null)
                _instance = new TestSingleton();

            return _instance;
        }

        #region Любые функции которые будет выполнять наш единственный экземпляр класса

        public void print()
        {
            Console.WriteLine("Hello");
        }

        #endregion
    }
}
