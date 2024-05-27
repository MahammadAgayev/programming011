using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{

    class HouseHoldItem
    {

        public string Color { get; set; }
    }

    class TV : HouseHoldItem
    {
        public int ScreenLength { get; set; }
    }

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }


    class Student : Person
    {
        public int StudentId { get; set; }
    }

    //class Book
    //{
    //    public string Type { get; set; }
    //}

    abstract class Shape
    {
        public virtual int Perimeter()
        {
            return 0;
        }

        //public virtual double Area()
        //{
        //    return 0;
        //}

        public abstract double Area();
    }

    class Triangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override int Perimeter()
        {
            return A + B + C;
        }

        public override double Area()
        {
            int p = this.Perimeter();

            double p2 = p / 2;

            double a = Math.Sqrt(p2 * (p2 - A) * (p2 - B) * (p2 - C));

            return a;
        }
    }

    class QuadAngular : Shape
    {
        public int A { get; set; }
        public int B { get; set; }

        public int C { get; set; }
        public int D { get; set; }

        public override double Area()
        {
            return A * B * C * D;
        }

        public override int Perimeter()
        {
            return A + B + C + D;
        }
    }

    class Circle : Shape
    {
        public int R { get; set; }

        public override double Area()
        {
            return Math.PI * R * R;
        }

        public override int Perimeter()
        {
            return (int)(2 * Math.PI * R);
        }
    }

    abstract class Iron
    {
        public abstract double MeltingPoint { get; }
    }

    class Lemonit : Iron
    {
        public override double MeltingPoint => 1674;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape e = new Triangle()
            //{
            //    A = 3,
            //    B = 4,
            //    C = 5,
            //};
            //Console.WriteLine(e.Area());

            //Person s = new Student();

            //Student d = new Person();

            //Student d1 = new Student();

            //Polymorphism

            //Shape a = new Triangle
            //{
            //    A = 1,
            //    B = 2, 
            //    C = 3,
            //};

            //Console.WriteLine(a.Perimeter());

            //Shape s = new Triangle()
            //{
            //    A = 3,
            //    B = 4,
            //    C = 5
            //};

            //Console.WriteLine(s.Area());

            //Circle c = new Circle
            //{
            //    R = 4
            //};

            //Console.WriteLine(c.Area());

            //Iron i = new Iron();
            Iron i = new Lemonit();
            Console.WriteLine(i.MeltingPoint);
        }
    }
}
