using System;
abstract class Man
{
    public string Name { get; private set; }
    public Man(string clothes)
    {
        this.Name = clothes;
    }
}

class ManInWinter : Man
{
    public ManInWinter():base("Man in winter")
    {

    }
}
class ManInSummer : Man
{
    public ManInSummer():base("Man in summer")
    {

    }
}

abstract class Decorator : Man
{
    protected Man man;
    public Decorator(string clothes, Man man) : base(clothes)
    {
        this.man = man;
    }
}

class ManInCoat : Decorator
{
    public ManInCoat(Man m):base(m.Name + " dressed in coat", m)
    {

    }
}
class ManInTshirt : Decorator
{
    public ManInTshirt(Man m):base(m.Name + " dressed in Tshirt", m)
    {

    }
}


namespace HW23._1
{
    class Program
    {
        public static Man DecoratorChoosing(Man m)
        {
            if(m is ManInWinter)
            {
                m = new ManInCoat(m);
            }
            else if(m is ManInSummer)
            {
                m = new ManInTshirt(m);
            }
            return m;
        }
        static void Main(string[] args)
        {
            Man man1 = new ManInWinter();
            Console.WriteLine(DecoratorChoosing(man1).Name);
            Man man2 = new ManInSummer();
            Console.WriteLine(DecoratorChoosing(man2).Name);
        }
    }
}
