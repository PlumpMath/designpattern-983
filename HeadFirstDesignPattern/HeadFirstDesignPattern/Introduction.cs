// <<Head First Design Patterns> p.40

using System;

class Duck
{
    // "꽥꽥"하고 운다
    public void quack()
    {
        Console.WriteLine("꽥꽥!");
    }
}

class Introduction
{
    static void Main(string[] args)
    {
        Duck duck = new Duck();
        duck.quack();
    }
}