using System;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document");

            Console.Write("Enter the name of your document: ");
            string name = Console.ReadLine();

            Console.Write("Enter the content of your document: ");
            string content = Console.ReadLine();

            try
            {

                StreamWriter sw = new StreamWriter(name + "txt");
                sw.WriteLine(content);
                sw.Close();
                Console.WriteLine("{0} was successfully saved. The document contains {1} characters.", name, content.Length);
                       
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
