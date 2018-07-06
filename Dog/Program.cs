using System;

namespace Dog
{
    enum Gender { Male, Female };

    class Dog
    {

        public string name;
        public string owner;
        public int age;
        public int sex;

        public string bark(int number)
        {
            while (number > 0)
            {
                Console.Write("Woof!");
                number--;
            }
        }

        public Dog()
        {
            Console.WriteLine("Object is being created.");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Dog puppy = new Dog();
            puppy.name = "Orion";
            puppy.owner = "Shawn";
            puppy.age = 1;
            puppy.sex = Gender.Male;

            puppy.bark(3);
            //Console.WriteLine(puppy.getTag());
        }
    }
}
