using System;

namespace Person
{
    public class Child : Person
    {
        public Child(string aName, int aAge)
            : base(aName, aAge)
        {

        }
        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Age cannot be graer than 15"); 
                }
                base.Age = value;
            }
        }
    }
}
