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
            Cat kitten = new Kitten(3, "Kitty", true);
            Console.WriteLine("Ten: " + kitten.Name + " -" + "Tuoi: " + kitten.Age + "-" + "Gioi Tinh Duc:" + kitten.Sex);
            kitten.Sound();
            Cat tom = new Tomcat(6, "Tom", true);
            Console.WriteLine("Ten: " + tom.Name + "-" + "Tuoi: " + tom.Age + "-" + "Gioi Tinh Duc:" + tom.Sex);
            tom.Sound();


            // Create array Animal

            // Dog
            Animal[] dog = new Dog[]
            {
                new Dog(3,"KiKi",true),
                new Dog(2,"MiMi",false),
                new Dog(3,"SaSa",true),
                new Dog(4,"LaLa",true),
                new Dog(3,"ToTo",true),
                new Dog(4,"MiLu",true),
                new Dog(5,"SangHa",false),
                new Dog(7,"OhYeah",false),
                new Dog(7,"LuLu",true),
                new Dog(6,"DoDo",true)
            };
            // Frog
            Animal[] frog = new Frog[]
            {
                new Frog(3,"TaTa",true),
                new Frog(3,"AAAA",true),
                new Frog(3,"BBBB",false),
                new Frog(6,"CCCc",true),
                new Frog(6,"DDDD",false),
                new Frog(5,"ZZZZ",true),
                new Frog(7,"TTTT",false),
                new Frog(7,"HHHH",true)
            };
            // Cat
            Animal[] cat = new Cat[]
            {
                new Kitten(4,"kitten1",true),
                new Kitten(4,"kitten2",true),
                new Kitten(3,"kitten3",true),
                new Kitten(6,"kitten4",true),
                new Tomcat(2,"tomcat1",true),
                new Tomcat(3,"tomcat2",true),
                new Tomcat(3,"tomcat3",true),
                new Tomcat(8,"tomcat4",true),
                new Tomcat(8,"tomcat5",true),
                new Tomcat(6,"tomcat6",true),
                new Tomcat(5,"tomcat7",true)

            };
            CaculateAverageAge(dog);
            CaculateAverageAge(frog);
            CaculateAverageAge(cat);
            Console.ReadLine();
        }

        //Function static method
        public static void CaculateAverageAge(Animal[] animals)
        {

            Console.WriteLine(animals.Average(animal => animal.Age));

        }


    }
}
