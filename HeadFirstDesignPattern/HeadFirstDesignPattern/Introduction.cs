﻿// <<Head First Design Patterns> p.40

using System;
using System.Diagnostics;

namespace HeadFirstDesignPattern
{
    static class Logger
    {
        public static void Log(string text)
        {
            Console.WriteLine(text);
        }
    }

    interface FlyBahavior
    {
        void fly();
    }

    interface QuackBehavior
    {
        void quack();
    }

    class FlyWithWings : FlyBahavior
    {
        public void fly()
        {
            Logger.Log("파닥파닥");
        }
    }

    class FlyNoWay : FlyBahavior
    {
        public void fly()
        {
            // do nothing
        }
    }

    class Quack : QuackBehavior
    {
        public void quack()
        {
            Logger.Log("꽦꽦");
        }
    }

    class Squeak : QuackBehavior
    {
        public void quack()
        {
            Logger.Log("삑삑");
        }
    }

    class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            // do nothing
        }
    }

    // 오리
    class Duck
    {
        FlyBahavior flyBehavior;
        QuackBehavior quackBehavior;

        public void performFly()
        {
            Debug.Assert(flyBehavior != null);

            flyBehavior.fly();
        }

        public void performQuack()
        {
            Debug.Assert(quackBehavior != null);

            quackBehavior.quack();
        }

        public virtual void swim()
        {
            Logger.Log("헤엄헤엄");
        }

        public virtual void display()
        {
            Logger.Log("오리모양");
        }
    }

    // 청둥오리
    class MallardDuck : Duck
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
        public override void display()
        {
            Logger.Log("고무오리모양");
        }
    }

    // 나무오리
    class DecoyDuck : Duck
    {
        public override void display()
        {
            Logger.Log("나무오리모양");
        }
    }

    class Introduction
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck();
            //duck.quack();
            duck.swim();
            duck.display();
            //duck.fly();

            Logger.Log("\n");

            MallardDuck mallardDuck = new MallardDuck();
            //mallardDuck.quack();
            mallardDuck.swim();
            mallardDuck.display();
            //mallardDuck.fly();

            Logger.Log("\n");

            RedHeadDuck redheadDuck = new RedHeadDuck();
            //redheadDuck.quack();
            redheadDuck.swim();
            redheadDuck.display();
            //redheadDuck.fly();

            Logger.Log("\n");

            RubberDuck rubberDuck = new RubberDuck();
            //rubberDuck.quack();
            rubberDuck.swim();
            rubberDuck.display();
            //rubberDuck.fly();

            Logger.Log("\n");

            DecoyDuck decoyDuck = new DecoyDuck();
            //decoyDuck.quack();
            decoyDuck.swim();
            decoyDuck.display();
            //decoyDuck.fly();

            Logger.Log("\n");

            #region Animal
            //Dog dog = new Dog();
            //dog.makeSound();

            //Cat cat = new Cat();
            //cat.makeSound();

            // Better implementation
            var animlas = AnimalFactory.Instance.getAnimals();
            foreach (Animal a in animlas)
            {
                a.makeSound();
            }
            #endregion
        }
    }
}