using System;

namespace HeadFirstDesignPattern
{
    interface MakeSoundBehavior
    {
        void makeSound();
    }

    abstract class Animal : MakeSoundBehavior
    {
        public abstract void makeSound();
    }

    class Cat : Animal
    {
        public override void makeSound()
        {
            Logger.Log("야옹야옹");
        }
    }

    class Dog : Animal
    {
        public override void makeSound()
        {
            Logger.Log("바우와우");
        }
    }
}