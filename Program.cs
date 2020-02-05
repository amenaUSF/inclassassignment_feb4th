using System;

namespace inclass_feb4th
{

    /*************************** 4. Using Multiple Classes *********************/
    /* class Program
     { 
         static void Main(string[] args)
             {
                 Car myObj = new Car();
                 Console.WriteLine(myObj.color);
             } 
     }*/


    /*******************  9. using multiple classes *****************/

    /*    class Program
        {
            static void Main(string[] args)
            {
                Car Ford = new Car();
                Ford.model = "Mustang";
                Ford.color = "red";
                Ford.year = 1969;

                Car Opel = new Car();
                Opel.model = "Astra";
                Opel.color = "white";
                Opel.year = 2005;

                Console.WriteLine(Ford.model);
                Console.WriteLine(Opel.model);
            }
        }
        */

    /***************** 12. Private Modifier - accessing from another class *******************/
    /*  class Program
      {
          static void Main(string[] args)
          {
              Car Ford = new Car("Mustang");
              Console.WriteLine(Ford.model);
          }
      }
      */

    /******************* 14. get and set methods for properties **************************/
    /*class Person
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }*/

    /**************************** 15. shortcut for get and set methods for properties *****************************/
    /*Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)*/
   /*
    class Person
    {
        public string Name  // property
        { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }
    */
}

