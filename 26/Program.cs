using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Person
    {
        public string Name { get; set; }

        public string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
    }

    //class Duck
    //{
    //    public void Walk()
    //    {
    //        Console.WriteLine("I'm walking");
    //    }

    //    public void Die()
    //    {
    //        Console.WriteLine("Died, Player +1 point");
    //    }

    //    public void Fly()
    //    {
    //        Console.WriteLine("I'm flying...");
    //    }
    //}

    class Character
    {
        public void Die()
        {
            Console.WriteLine("Died, Player +1 point");
        }
    }

    class Duck : Character
    {
        public void Walk()
        {
            Console.WriteLine("walking...");
        }
    }

    class Sparrow : Character
    {
        public void Fly()
        {
            Console.WriteLine("flying...");
        }
    }

    class YellowSparrow : Sparrow
    {
        public void Shine()
        {
            Console.WriteLine("Yellow shining");
        }
    }

    //parent class
    class Animal
    {
        public void Move()
        {
            Console.WriteLine("moving around");
        }
    }

    //child class, derivative
    class Cat : Animal
    {
        public void Jump()
        {
            Console.WriteLine("jumping, jumping");
        }
    }

    class Company
    {
        public string Title { get; set; }
        public decimal AnnualIncome { get; set; }
    }

    class ChocolateCompany : Company
    {
        public string[] ChocolateTypes { get; set; }
    }

    //this is wrong, branch is separate object
    class Branch : ChocolateCompany
    {

    }

    //this is correct
    class Hermes : Company
    {

    }


    //--------------
    class Country
    {
        public string Capital { get; set; }
        public string FlagInfo { get; set; }
        public string Hymmn { get; set; }
    }

    //this is wrong
    //class Baku : Country
    //{

    //}

    class EuropeanCountry : Country
    {

    }

    class AsianCountry : Country
    {
        public int WeeklyWorkHours { get; set; }
    }

    class Azerbaijan : AsianCountry
    {

    }

    class City
    {
        public int Population { get; set; }
    }

    class Baku : City
    {
        public string[] SightseeingAdresses { get; set; }
    }


    class Culture
    {
        public DateTime CreationTime { get; set; }
    }

    class SpanishCulture
    {
        public DateTime NextSomeHoliday { get; set; }
    }

    class AfrikanCulture
    {
        public string RainDanceSong { get; set; }
    }

    class Car
    {
        public int TopSpeed { get; set; }

        public int Accelaration { get; set; }
    }

    class AutomaticGearCar : Car
    {

    }

    class ManualGearCar : Car
    {
        public int CurrentGear { get; set; }
    }

    class SportsCar : ManualGearCar
    {
        public int GearBoxPedals { get; set; }
    }

    class Shop
    {
        public string[] Goods { get; set; }
    }

    class GameShop
    {
        public string[] Guns { get; set; }
    }

    class Weapon
    {
        public int TotalDamage { get; set; }

        public void Hit()
        {
            Console.WriteLine("Stroke the enemy");
        }
    }

    class Sword : Weapon
    {
        public int Range { get; set; }
    }

    class Gun : Weapon
    {

    }

    class AutomaticGun : Gun
    {

    }

    class Cofee
    {
        public int TotalUsedEspresso { get; set; }

        public virtual void Brew()
        {
            Console.WriteLine("pour espresso");
        }

        public virtual int CafeinEffectRate
        {
            get
            {
                return 30;
            }
        }
    }

    class Latte : Cofee
    {
        //public void Brew()
        //{
        //    Console.WriteLine("pour milk");

        //    Console.WriteLine("pour espresso");
        //}

        public override void Brew()
        {
            Console.WriteLine("pour milk");
            base.Brew();
        }

        public override int CafeinEffectRate
        {
            get
            {
                return 13;
            }
        }
    }

    class Coppucino : Cofee
    {
        public void Brew()
        {
            Console.WriteLine("pour espresso");

            Console.WriteLine("pour milk");
        }
    }

    class Robot
    {
        public void Walk()
        {
            Console.WriteLine("walking...");
        }

        public virtual void MakeVoice()
        {
            Console.WriteLine("Simply making voice");
        }
    }

    class HumanoidRobot : Robot
    {
        public void Walk()
        {
            Console.WriteLine("walking just like human");
        }

        public override void MakeVoice()
        {
            Console.WriteLine("I'm talking as human!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Assembly
            //65 CALL FA7B

            //C
            //funksional languages

            //java, C# -> OOP object oriented programming

            //Polymorphism - çoxölçülülük
            //Encapsulation 
            //Inheritence
            //Abstraction

            //inheritence - miras almaq
            //code reuse

            //Obyektlər = OOP 

            //Duck d = new Duck();

            //Sparrow s = new Sparrow();

            //d.Die();
            //s.Die();

            //d.Walk();
            //s.Fly();


            //YellowSparrow yp = new YellowSparrow();

            //yp.Die();
            //yp.Fly();
            //yp.Shine();


            //Cat t = new Cat();
            //t.Move();
            //t.Jump();


            //Cofee c = new Cofee();
            //c.Brew();

            //Latte l = new Latte();
            //l.Brew();

            //Cofee c = new Latte();
            //c.Brew();

            Robot r = new HumanoidRobot();
            r.Walk();

            Robot r1 = new Robot();
            r1.Walk();

            Robot r2 = new HumanoidRobot();
            r2.MakeVoice();

            HumanoidRobot r3 = new HumanoidRobot();
            r3.MakeVoice();
        }
    }
}
