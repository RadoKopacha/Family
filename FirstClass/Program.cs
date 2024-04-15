namespace FirstClass
{
    internal class Program
    {
        static void Main()
        {
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = new Dog();
            Dog dog4 = new Dog();

            dog1.name = "Pumqrcho";
            dog1.breed = "Pumqre";
            dog1.age = 2;
            dog1.weight = 5;

            dog1.Bark();

            dog2.name = "Bobcho";
            dog2.breed = "Karakachanka";
            dog2.age = 5;
            dog2.weight = 30;

            dog2.Bark();

            Console.WriteLine(dog2.Growup());

        }
    }
}
