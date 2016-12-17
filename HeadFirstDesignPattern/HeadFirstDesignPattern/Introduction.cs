// <<Head First Design Patterns> p.40

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
            Logger.Log("[저는 못 날아요]");
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
            Logger.Log("[저는 소리를 못 내요]");
        }
    }

    // 오리
    class Duck
    {
        protected FlyBahavior flyBehavior;
        protected QuackBehavior quackBehavior;

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

        public void performFly()
        {
            Debug.Assert(flyBehavior != null);

            flyBehavior.fly();
        }
    }

    // 청둥오리
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Logger.Log("청둥오리모양");
        }
    }


    // 아메리카 흰죽지
    class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Logger.Log("아메리카흰죽지모양");
        }
    }

    // 고무오리
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }

        public override void display()
        {
            Logger.Log("고무오리모양");
        }
    }

    // 나무오리
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void display()
        {
            Logger.Log("나무오리모양");
        }
    }

    // 모형오리
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Logger.Log("모형오리모양");
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
            mallardDuck.performQuack();
            mallardDuck.swim();
            mallardDuck.display();
            mallardDuck.performFly();

            Logger.Log("\n");

            RedHeadDuck redheadDuck = new RedHeadDuck();
            redheadDuck.performQuack();
            redheadDuck.swim();
            redheadDuck.display();
            redheadDuck.performFly();

            Logger.Log("\n");

            RubberDuck rubberDuck = new RubberDuck();
            rubberDuck.performQuack();
            rubberDuck.swim();
            rubberDuck.display();
            rubberDuck.performFly();

            Logger.Log("\n");

            DecoyDuck decoyDuck = new DecoyDuck();
            decoyDuck.performQuack();
            decoyDuck.swim();
            decoyDuck.display();
            decoyDuck.performFly();

            Logger.Log("\n");

            ModelDuck modelDuck = new ModelDuck();
            modelDuck.performQuack();
            modelDuck.swim();
            modelDuck.display();
            modelDuck.performFly();

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

            Console.ReadLine();
        }
    }
}