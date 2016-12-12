using System;

namespace HeadFirstDesignPattern
{
    interface MakeSoundBehavior
    {
        void makeSound();
    }

    class Animal : MakeSoundBehavior
    {
        public virtual void makeSound()
        {
        }
    }
}