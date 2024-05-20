using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _25
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //SRE - Site Reliability Engineer

            //Site Reliability Engineering Manager
            //Sistem Dayanıqlığı üzrə mühəndis

            //SRE nədir?

            //try catch/ istisnaların emal olunması

            //Software Engineer
            //Software Developer

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine(a / b);

            //

            //Person p = new Person();
            //Console.WriteLine(p.Name.PadRight(10));

            //int[] arr = new int[5];
            //arr[5] = 1;

            //List<string> strings = new List<string>();

            //while (true)
            //{
            //    strings.Add("hello");

            //    //string s = "hello";
            //}

            //Recurse();

            //while (true)
            //{
            //}

            //OutofMemoryException
            //StackOverflowException

            Console.OutputEncoding = Encoding.UTF8;


            //try
            //{
            //    Console.WriteLine(a / b);
            //}
            //catch
            //{
            //    Console.WriteLine("Bölünmə zamanı xəta baş verdi");
            //}

            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());

            //    Console.WriteLine(a / b);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0-a bölmək olmaz");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Proqram yalnız ədəd qəbul edir!");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Xəta baş verdi");
            //}

            //CashOut();
            //Console.WriteLine("Proqram başa çatdı");


            //try
            //{

            //}
            //catch (Exception e)
            //{

            //}
            //finally
            //{

            //}


            //try
            //{
            //    //downloading file from internet

            //    //download intermediate file

            //    //merge them into one main file
            //}
            //finally
            //{
            //    //remove intermediate files
            //}

            //throw

            //RecordLesson();
            //Console.WriteLine("Proqram başa çatdı");
        }

        static void RecordLesson()
        {
            Console.WriteLine("recording lesson");

            int emptySpace = 0;

            if (emptySpace == 0)
            {
                throw new Exception("Cannot record lesson due to insufficient disk space");
            }
        }


        static decimal CashOut()
        {
            int myPin = 7609;
            try
            {
                int retryAttempt = 3;
                while (retryAttempt > 0)
                {
                    int pin = int.Parse(Console.ReadLine());

                    if (pin == myPin)
                    {
                        break;
                    }
                    else
                    {
                        retryAttempt--;
                        Console.WriteLine($"pin is wrong, you have {retryAttempt} attempt left");
                    }
                }

                decimal amount = decimal.Parse(Console.ReadLine());
                return amount;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Pin kod düzgün formatda deyil");
                Console.WriteLine(e.ToString());

                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Xəta baş verdi");
                Console.WriteLine(e.ToString());

                return 0;
            }
            finally
            {
                Console.WriteLine("Kart geri qaytarıldı");
            }
        }

        static void Recurse()
        {
            Recurse();
        }
    }
}
