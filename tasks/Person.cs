using System;
namespace tasks
{
   public class Person
    {

        internal string name;
        private string surname;
        public string address;
        public int age=15;

        public Person()
        {
            surname = "Hadizade";
        }

        public void ShowSurnameName()
        {
            Console.WriteLine( surname );

        }
        
    }
}

