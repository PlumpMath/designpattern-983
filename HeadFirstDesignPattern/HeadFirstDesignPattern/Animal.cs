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
            meow();
        }

        private void meow()
        {
            Logger.Log("야옹야옹");
        }
    }

    class Dog : Animal
    {
        public override void makeSound()
        {
            bark();
        }

        private void bark()
        {
            Logger.Log("바우와우");
        }
    }
}