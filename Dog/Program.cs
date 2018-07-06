using System;

namespace Dog
{
    public enum Gender { Male, Female};

    public class Dog
    {

        public string name;
        public string owner;
        public int age;
        public Gender gender;

        public void Bark(int number)
        {
            while (number > 0)
            {
                Console.WriteLine("Woof!");
                number--;
            }
        }

        public Dog(string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }

        public string GetTag()
        {
            string tag = "If lost, call " + owner + ".";
            if (gender == Gender.Male)
            {
                tag += " His ";
            }
            else
            {
                tag += " Her ";
            }
            tag += "name is " + name + " and ";
            if(gender == Gender.Male)
            {
                tag += "he";
            }
            else
            {
                tag += "she";
            }
            tag += " is " + age + " year";
            if (age != 1)
            {
                tag += "s";
            }
            tag += " old.";
            return tag;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
            myDog.Bark(1);
            Console.WriteLine(myDog.GetTag());

           
        }
    }
}
