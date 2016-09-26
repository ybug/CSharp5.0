using System;

namespace SealedMethod
{
    class Base
    {
        public virtual void SealMe()
        {

        }
    }

    class Derived : Base
    {
        public override void SealMe()
        {

        }
    }

    class WantToOverride : Derived
    {
        public override void SealMe()
        {

        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
        }
    }
}
