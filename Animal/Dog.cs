using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Dog : Animal
    {
        public Dog(int age, string name, bool sex) : base(age, name, sex)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Dog sound is Go go");
        }
    }
}
