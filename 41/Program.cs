using _40.Repositeries.Abstract;
using _40.Repositeries.SqlServer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    class Counter
    {
        static Counter _counter;

        private Counter()
        {
            Count++;
            Count2++;
        }

        public int Count { get; set; }
        public static int Count2 { get; set; }


        public static Counter GetCounter()
        {
            if (_counter == null)
            {
                _counter = new Counter();
            }

            return _counter;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //singletone
            //factory

            //Counter c = new Counter();
            //Counter c2 = new Counter();

            //Counter c = GetCounter();
            //Counter c2 = GetCounter();

            //Counter c = Counter.GetCounter();
            //Counter c2 = Counter.GetCounter();

            //Console.WriteLine(c.Count);
            //Console.WriteLine(c2.Count);

            //Console.WriteLine("----------------------------");
            //Console.WriteLine(Counter.Count2);

            //Factory pattern

            //IUnitOfWork unitOfWork = UnitOfWorkFactory.GetUnitOfWork("sqlserver");
            //IUnitOfWork unitOfWork1 = new SqlUnitOfWork();

            //design patterns
        }

        //static Counter counter;
        //static Counter GetCounter()
        //{
        //    if(counter == null)
        //    {
        //        counter = new Counter();
        //    }

        //    return counter;
        //}
    }
}
