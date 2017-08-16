using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitten = new Kitten(12, "con", true);
            kitten.Sound();
            Console.WriteLine("tuoi meo,{0}", kitten.Age);
            Console.WriteLine("gioi tinh meo {0}", kitten.Sex);
            Console.ReadLine();
        }
    }
}
