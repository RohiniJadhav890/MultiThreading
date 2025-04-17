using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Program
    {

        public static void DisplayTable()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Started");
            int i;
            int n = 2;
            for (i = 1; i <= 10; i++)
            { 
                Console.WriteLine(Thread.CurrentThread.Name+": "+n+"*"+i+"= "+(n * i));
                if (i == 3)
                {
                    Thread.Sleep(1000);
                } 
            }
            Console.WriteLine(Thread.CurrentThread.Name+"ended");
        }

        static void Method()
        {
            Console.WriteLine(Thread.CurrentThread.Name+" Started");
            int i;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method -1:"+i);

            }
            Thread.Sleep(1000);

            Console.WriteLine(Thread.CurrentThread.Name + " Ended");
        }
        static void Method1()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Started");
            int i;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method -2:" + i);
                if (i == 3)
                {
                    Console.WriteLine("Fetching  data From Database");
                    Thread.Sleep(1500);
                    Console.WriteLine("  ");
                }
            }
            Console.WriteLine(Thread.CurrentThread.Name + " Ended");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.ReadKey();

            //Thread t = Thread.CurrentThread;
            //t.Name = "Test";
            //Console.WriteLine(t.Name);

            //Thread t4 = new Thread(DisplayTable)
            //{
            //    Name = "Thraed-1"
            //};

            //Thread t1 = new Thread(Method)
            //{
            //    Name = "Thraed-1"
            //};
            //Thread t2 = new Thread(Method1)
            //{
            //    Name = "Thraed-2"
            //};
            //Thread t3 = new Thread(Method)
            //{
            //    Name = "Thraed-3"
            //};
            ////t1.Start();
            //t4.Start();
            //t4.Join();
            //t2.Start();
            //t3.Start();

            //Syncronation s1 = new Syncronation();
            //Thread t1 = new Thread(s1.Method1);
            //Thread t2 = new Thread(s1.Method1);
            //Thread t3 = new Thread(s1.Method1);

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //Bookmyshow Example in thread
            BookMyShow b1 = new BookMyShow();
            Thread t1 = new Thread(b1.Booking)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(b1.Booking)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(b1.Booking)
            {
                Name = "Thread3"
            };
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
