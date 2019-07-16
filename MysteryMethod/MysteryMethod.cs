using System;
using System.Collections.Generic;

namespace Mystery_Method
{
    public class MystryMethod
    {
        

        public static void Main(string[] args)
        {
                                           
        }

        //3. Mystery Method               
        //Describe what the Mystery method does and discuss any 
        //potential bugs and possible fixes.

        /// <summary>
        /// public class Person accessesible to anyone who has access to the .exe
        /// </summary>
        /// 

        //First change the class P to Person so it is more readable
        public class Person
        {
            public string Name;
            public Person[] Acquaintances;

            public Person(string name, Person[] acquaintances)
            {
                if (String.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Name cannot be null or white space.",
                     "name");
                }

                this.Name = name;
                this.Acquaintances = acquaintances;
            }

            // Mystery class tells where a name is in the acquaintances array
            public bool Mystery(string name)
            {
                if (String.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Name cannot be null or white space.",
                     "name");
                }

                //Because of the change of the name of the class from P to Person this
                //refactored and fixed the naming issue in the myStack object initialization

                //The code below is using a foreach loop to Push each person on the acquitance 
                //stack
                Stack<Person> myStack = new Stack<Person>();
                foreach (Person acquaintance in this.Acquaintances)
                {
                    myStack.Push(acquaintance);
                }


                //Next it will return true or false if the Person name is equal to an aquitance in the 
                //stack
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
