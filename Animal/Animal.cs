using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Animal
{
    abstract class Animal : ISound
    {
        private int age;
        private string name;
        private bool sex;

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public bool Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }
        //contructor
        public Animal(int age, string name, bool sex)
        {
            this.age = age;
            this.name = name;
            this.sex = sex;
        }


        public abstract void Sound();


    }
}
