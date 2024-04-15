using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Person
    {
        private string name;
        private int age;
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value < 0|| value > 117)
                {
                    Console.WriteLine("You dont exist at that point ");
                    this.age = 0;
                }
                else
                {
                    this.age = value;
                }
            }
        }
        public void Introduse()
        {
            Console.WriteLine($" I am {this.name} an my age is {this.age} ");
        }
    }
}
