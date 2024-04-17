using System;

namespace Domashna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family myFamily = new Family();
            myFamily.FamilyName = "Nikolovi";
            Console.Write("How many members: ");
            int count = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write($"enter {i + 1} person: ");
                Person current = new Person();
                Console.Write($"enter name of {i + 1} person: ");
                current.Name = Console.ReadLine();
                Console.Write($"enter age of {i + 1} person: ");
                current.Age = int.Parse(Console.ReadLine());
                myFamily.Members.Add(current);
            }
            myFamily.SortingMembers();
            //Console.WriteLine();
            //Person oldest = myFamily.Members[count - 1];
            //Person youngest = myFamily.Members[0];
            //Console.Write("Oldest: ");
            //oldest.PrintOldestAndYoungest();
            //Console.Write("Youngest: ");
            //youngest.PrintOldestAndYoungest();
            //foreach (Person member in myFamily.Members)
            //{
            //    total += member.Age;
            //}
            //Console.WriteLine();
            myFamily.PrintAll();
            //Console.WriteLine();
            //Console.WriteLine($"Sum of years: {total}");
            
            myFamily.PrintYoungest();
            myFamily.PrintOldest();
            int sum = myFamily.SumOfTheFamilies();
            Console.WriteLine($"The sum of all members age is {sum}.");
        }
    }
}
