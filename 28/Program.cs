using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    interface IPaymentService
    {
        bool Pay(string customerId, decimal amount);

        //int CardNumber { get; set; }
    }

    interface IAmountBlockable
    {
        void BlockAmount(string customerId, decimal amount);
    }

    class VisaPaymentService : PaymentService, IPaymentService, IAmountBlockable
    {
        public void BlockAmount(string customerId, decimal amount)
        {
            Console.WriteLine("blocking amount from customer balance");
        }

        public override bool Pay(string customerId, decimal amount)
        {
            Console.WriteLine("calling visa payment systems");

            return true;
        }
    }

    class MastercardPaymentService : PaymentService, IPaymentService
    {
        public override bool Pay(string customerId, decimal amount)
        {
            Console.WriteLine("calling mastercard payment systems");

            return true;
        }
    }

    abstract class PaymentService
    {
        //abstract class may have method body
        public void PrintPaymentInfo()
        {
            Console.WriteLine("Printing payment info");
        }

        //we could declare properties, but in interface should implement properties
        public int CardNumber { get; set; }

        public abstract bool Pay(string customerId, decimal amount);
    }


    class Car
    {
        public int Speed { get; set; }
    }

    interface IDrivable
    {
        void Move();
    }

    interface IFlyable
    {
        void Fly();
    }

    class SportsCar : Car, IDrivable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Sports car is flying");
        }

        public void Move()
        {
            Console.WriteLine("sports car moving");
        }
    }


    class Animal
    {

    }

    interface IWalkable
    {
        void Walk();
    }

    interface ISwimmable
    {
        void Swim();
    }

    class Elephant : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("walkable");
        }
    }

    class Penguin : IWalkable, ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("i'm swimming");
        }

        public void Walk()
        {
            Console.WriteLine("i'm walking");
        }
    }

    interface IPerimeterCalculatable
    {
        void Perimeter();
    }

    abstract class Shape
    {
        public abstract double Area();

        public virtual void PrintSides()
        {

        }

        public void PrintShape()
        {

        }
    }

    class Triangle : Shape, IPerimeterCalculatable
    {
        public override double Area()
        {
            throw new NotImplementedException();
        }

        public void Perimeter()
        {
            Console.WriteLine("calculate perimeter");
        }

    }

    //capability, 
    //able, or
    internal class Program
    {
        static void Main(string[] args)
        {
            //abstraction

            //abstract - interface

            //PaymentService visa = new VisaPaymentService();
            //service.Pay("111111", 1000);

            //PaymentService mastercard = new MastercardPaymentService();
            //service2.Pay("111111", 400);

            //Order(mastercard);

            //abstract
            //interface - 

            //spaghetti code

            PaymentService visa = new VisaPaymentService();
            PaymentService mastercard = new MastercardPaymentService();

            Order(visa);
        }

        static void Order(PaymentService payment)
        {
            Console.WriteLine("customer gave order");

            //if (payment is IAmountBlockable)
            //{
            //    ((IAmountBlockable)payment).BlockAmount("019928243", 50);
            //}

            Console.WriteLine("driver found for customer");

            Console.WriteLine("ride finished");

            payment.Pay("019928243", 50);
            Console.WriteLine("customer paid for the ride");

            payment.PrintPaymentInfo();
        }
    }
}
