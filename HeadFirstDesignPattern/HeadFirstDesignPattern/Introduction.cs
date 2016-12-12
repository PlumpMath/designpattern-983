// <<Head First Design Patterns> p.40

using System;

static class Logger
{
    public static void Log(string text)
    {
        Console.WriteLine(text);
    }
}

// 오리
class Duck
{
    public virtual void quack()
    {
        Logger.Log("꽦꽦");
    }

    public virtual void swim()
    {
        Logger.Log("헤엄헤엄");
    }

    public virtual void fly()
    {
        Logger.Log("파닥파닥");
    }

    public virtual void display()
    {
        Logger.Log("오리모양");
    }
}

// 청둥오리
class MallardDUck : Duck
{
    public override void display()
    {
        Logger.Log("청둥오리모양");
    }
}


// 아메리카 흰죽지
class RedHeadDuck : Duck
{
    public override void display()
    {
        Logger.Log("아메리카흰죽지모양");
    }
}

// 고무오리
class RubberDuck : Duck
{
    public override void quack()
    {
        Logger.Log("쁶쁶");
    }

    public override void display()
    {
        Logger.Log("고무오리모양");
    }

    public override void fly()
    {
        // do nothing
    }
}

// 나무오리
class DecoyDuck : Duck
{
    public override void quack()
    {
        // do nothing
    }

    public override void display()
    {
        Logger.Log("나무오리모양");
    }

    public override void fly()
    {
        // do nothing
    }
}

class Introduction
{
    static void Main(string[] args)
    {
        Duck duck = new Duck();
        duck.quack();
        duck.swim();
        duck.display();
        duck.fly();

        Logger.Log("\n");

        MallardDUck mallardDuck = new MallardDUck();
        mallardDuck.quack();
        mallardDuck.swim();
        mallardDuck.display();
        mallardDuck.fly();

        Logger.Log("\n");

        RedHeadDuck redheadDuck = new RedHeadDuck();
        redheadDuck.quack();
        redheadDuck.swim();
        redheadDuck.display();
        redheadDuck.fly();

        Logger.Log("\n");

        RubberDuck rubberDuck = new RubberDuck();
        rubberDuck.quack();
        rubberDuck.swim();
        rubberDuck.display();
        rubberDuck.fly();

        Logger.Log("\n");

        DecoyDuck decoyDuck = new DecoyDuck();
        decoyDuck.quack();
        decoyDuck.swim();
        decoyDuck.display();
        decoyDuck.fly();
    }
}