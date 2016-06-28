using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestAndDebug
{

    class MyArray
    {
        public int middle;
        public int min = int.MaxValue;
        public int max = int.MinValue;
        public int[,] a =  { { 1, 2, 3},
                             { 0, 3, 6},
                             { 8, 6, 4}};

        public void FillandSearchMiddle()
        {
            int m = 3/*int.Parse(Console.ReadLine())*/;

         

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //inc++;
                    //a[i, j] = r.Next(0, 9);

                    if (i > j)
                    {
                        if (a[i, j] < min)
                        {
                            min = a[i, j];
                        }
                        if (a[i, j] > max)
                        {
                            max = a[i, j];
                        }
                    }
                }
            }

            middle = (max + min) / 2;
            Console.WriteLine("Middle = " + middle);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = m - 1; i >= 0; --i)
            {
                for (int j = m - 1; j >= 0; --j)
                {
                    if (i == j)
                        a[i, j] -= middle;
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    [TestFixture]
    class Test
    {
        [Test]
        public void Check1()
        {
            MyArray arr = new MyArray();
            arr.FillandSearchMiddle();
            Assert.AreEqual(3, arr.middle);//4
        }

        [Test]
        public void Check2()
        {
            MyArray arr = new MyArray();
            arr.FillandSearchMiddle();
            Assert.AreEqual(8, arr.max);//8
        }

        [Test]
        public void Check3()
        {
            MyArray arr = new MyArray();
            arr.FillandSearchMiddle();
            Assert.AreEqual(0, arr.min);
        }

        [Test]
        public void Check4()
        {
            MyArray arr = new MyArray();
            arr.FillandSearchMiddle();
            Assert.AreEqual(0, arr.a[1, 0]);
        }

        [Test]
        public void Check5()
        {
            MyArray arr = new MyArray();
            arr.FillandSearchMiddle();
            Assert.AreEqual(-1, arr.a[1, 1]);
        }

        [Test]
        public void Check6()
        {
            MyArray arr = new MyArray();
            arr.FillandSearchMiddle();
            Assert.AreEqual(6, arr.a[1, 2]);
        }


        class Program
        {
            static void Main(string[] args)
            {
                Test test = new Test();
                test.Check1();
                test.Check2();
                test.Check3();
                test.Check4();
                test.Check5();
                test.Check6();
                //try
                //{
                //    test.Check1();
                //    Console.WriteLine("Тест 1 прошел успешно");
                //}
                //catch { Console.WriteLine("Тест 1, ошибка!"); }
                //try
                //{
                //    test.Check2();
                //    Console.WriteLine("Тест 2 прошел успешно");
                //}
                //catch { Console.WriteLine("Тест 2, ошибка!"); }
                //try
                //{
                //    test.Check3();
                //    Console.WriteLine("Тест 3 прошел успешно");
                //}
                //catch { Console.WriteLine("Тест 3, ошибка!"); }
                //try
                //{
                //    test.Check4();
                //    Console.WriteLine("Тест 4 прошел успешно");
                //}
                //catch { Console.WriteLine("Тест 4, ошибка!"); }
                //try
                //{
                //    test.Check5();
                //    Console.WriteLine("Тест 5 прошел успешно");
                //}
                //catch { Console.WriteLine("Тест 5, ошибка!"); }
                //try
                //{
                //    test.Check6();
                //    Console.WriteLine("Тест 6 прошел успешно");
                //}
                //catch { Console.WriteLine("Тест 6, ошибка!"); }

                Console.ReadLine();
            }
        }
    }
}
