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
}