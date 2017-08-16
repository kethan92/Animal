using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Frog : Animal, ISound
    {
       // bool 
        public Frog(int age, string name, bool sex) : base(age, name, sex)
        {

        }

        void ISound.Sound()
        {
            Console.WriteLine("Frog sound is frog frog");
        }
    }
}
