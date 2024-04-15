namespace Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person perosn1 = new Person();
            //perosn1.Name = "Rado";
            //perosn1.Age = 15    ;
            //perosn1.Introduse();

            //List<Person> group2 = new List<Person>();
            //string propt = "Da";   
            //int index = 0;
            //while(propt == "Da")
            //{
            //    Person person = new Person();              
            //    Console.Write($"Write the name of {index} :");
            //     person.Name = Console.ReadLine();
            //    Console.Write($"Write the age of {index} :");
            //    person.Age = int.Parse(Console.ReadLine());

            //    group2.Add( person );

            //    Console.WriteLine("Do you want more");
            //    propt = Console.ReadLine();
            //}
            //foreach( Person item in group2) 
            //{
            //    item.Introduse();
            //}

           
            Family family1 = new Family();
            family1.FamilyName = "Nikolovi";
            Console.Write("how many family members you will have: ");
            int countmembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < countmembers; i++)
            {
                Console.WriteLine($"Write {i + 1} person :");
                Person currenperson = new Person();

                Console.Write("Write your family member name: ");
                currenperson.Name = Console.ReadLine();

                Console.Write("Age:");
                currenperson.Age = int.Parse(Console.ReadLine());

                family1.Familymembers.Add(currenperson);

            }

            family1.PrintAllFamily();

            for (int i = 0; i < family1.Familymembers.Count; i++)
            {
                for (int j = 0; j < family1.Familymembers.Count - 1; j++)
                {
                    if (family1.Familymembers[j].Age> 
                        family1.Familymembers[j+ 1].Age)
                    {
                        Person temp = family1.Familymembers[j];
                        family1.Familymembers[j] = family1.Familymembers[j+ 1];
                        family1.Familymembers[j+ 1] = temp;
                    }
                }
            }
        }
    }
}
