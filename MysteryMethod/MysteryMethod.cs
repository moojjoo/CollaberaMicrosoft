using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystery_Method
{
    public class MystryMethod
    {
        public static void Main(string[] args)
        {
            // Populate Person class with name and aquatiances
            Person p = new Person();
            
            p.Name = "Robert";
            p.Acquaintances. = { p.Name = "Tom", p.Name="Tommy"};
            







        }

        //3. Mystery Method               
        //Describe what the Mystery method does and discuss any 
        //potential bugs and possible fixes.

        /// <summary>
        /// public class P accessesible to anyone who has access to the .exe
        /// </summary>
        public class Person
        {
            public string Name;
            public Person[] Acquaintances;

            public Person()
            {

            }

            public Person(string name, Person[] acquaintances)
            {
                if (IsNameNullOrWhiteSpace(name)) //RBD change to call Mystery
                {
                    throw new ArgumentException("Name cannot be null o white space.",
                     "name");
                }

                this.Name = name;
                this.Acquaintances = acquaintances;
            }

            public bool IsNameNullOrWhiteSpace(string name)
            {
                if (String.IsNullOrWhiteSpace(name))
                {
                    return true;
                }

                Stack<Person> myStack = new Stack<Person>();
                foreach (Person acquaintance in this.Acquaintances)
                {
                    myStack.Push(acquaintance);
                }

                do
                {
                    var person = myStack.Pop();

                    if (person.Name.Equals(name))
                    {
                        return true;
                    }

                    foreach (Person acquaintance in person.Acquaintances)
                    {
                        myStack.Push(acquaintance);
                    }

                } while (myStack.Count >= 0);

                return false;
            }
        }

    }
}
