using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
     public class Family
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

        private List<Person> familymembers= new List<Person>(); 
        public List<Person> Familymembers
        {
            get
            {
                return familymembers;
            }
            set
            {
                familymembers = value;
            }
        }
        public void PrintAllFamily()
        {
            Console.WriteLine($"Family: {this.FamilyName}");
            foreach (Person item in this.familymembers)
            {
                item.Introduse();
            }
        }
    }
}
