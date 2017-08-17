using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Tomcat : Cat
    {
        public Tomcat(int age, string name, bool sex) : base(age, name, true)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Tomcat is sound gru gru");
        }
    }
}
