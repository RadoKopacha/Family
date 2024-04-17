using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashna
{
    internal class Family
    {
        private string familyName;
        public string FamilyName
        {
            get
            {
                return familyName;
            }
            set
            {
                familyName = value;
            }
        }

        private List<Person> members = new List<Person>();
        public List<Person> Members
        {
            get
            {
                return members;
            }
            set
            {
                members = value;
            }
        }

        public void PrintAll()
        {
            Console.WriteLine($"Family: {this.FamilyName}");
            foreach (Person item in this.Members)
            {
                item.Intruduce();
            }
        }
        public void PrintYoungest()
        {
            int minage = int.MaxValue;
            Person yonger = new Person();

            foreach (Person item in this.Members)
            {
                if (item.Age < minage)
                {
                    minage = item.Age;
                    yonger = item;
                }
            }
            Console.WriteLine("Nai-mladiq chovek v semeistvoto e:");
            yonger.Intruduce();
        }

        public void PrintOldest()
        {
            int minage = 0;
            Person yonger = new Person();

            foreach (Person item in this.Members)
            {
                if (item.Age > minage)
                {
                    minage = item.Age;
                    yonger = item;
                }
            }
            Console.WriteLine("Nai-stariq chovek v semeistvoto e:");
            yonger.Intruduce();
        }
        public int SumOfTheFamilies()
        {
            int sum = 0;
            foreach (Person item in this.Members)
            {
                sum = sum + item.Age;

            }
            return sum;
        }

        internal void SortingMembers()
        {
            int count = this.Members.Count;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (this.Members[j].Age > this.Members[j + 1].Age)
                    {
                        Person temp = this.Members[j];
                        this.Members[j] = this.Members[j + 1];
                        this.Members[j + 1] = temp;
                    }
                }
            }
        }
    }
}
