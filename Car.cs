using System;
using System.Collections.Generic;
using System.Text;

namespace inclass_feb4th
{

    /************************************ 1. Create a class named "Car" with a variable color: ************************/
    /*  class Car
        {
            string color = "red";
        }*/


    /************************  2. Create an object called "myObj" and use it to print the value of color: ********************************/
    /*    class Car
        {
            string color = "red";

            static void Main(string[] args)
            {
                Car myObj = new Car();
                Console.WriteLine(myObj.color);
            }
        }*/

    /**************************  3.Create two objects of Car: ********************************/
    /* class Car
     {
         string color = "red";
         static void Main(string[] args)
         {
             Car myObj1 = new Car();
             Car myObj2 = new Car();
             Console.WriteLine(myObj1.color);
             Console.WriteLine(myObj2.color);
         }
     }*/


    /*************************** 4. Using Multiple Classes *********************/
    /* class Car
     {
         public string color = "red";
     }
     */


    /****************************  5. Create a Car class with three class members: two fields and one method. ********************************/
    /*    class myclass
        {
            // Class members
            string color = "red";        // field
            int maxSpeed = 200;          // field
            public void fullThrottle()   // method
            {
                Console.WriteLine("The car is going as fast as it can!");
            }
            static void Main(string[] args)
            {
                myclass myObj = new myclass();
                Console.WriteLine(myObj.color);
                Console.WriteLine(myObj.maxSpeed);
            }
        }*/

    /********************* 6. You can also leave the fields blank, and modify them when creating the object:***********************/
    /*    class Car
        {
            string color;
            int maxSpeed;

            static void Main(string[] args)
            {
                Car myObj = new Car();
                myObj.color = "red";
                myObj.maxSpeed = 200;
                Console.WriteLine(myObj.color);
                Console.WriteLine(myObj.maxSpeed);
            }
        }
        */

    /********************** 7. This is especially useful when creating multiple objects of one class: ********************/
    /*    class Car
        {
            string model;
            string color;
            int year;

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

    /******************* 8.Object Methods **********************/
    /*class Car
    {
        string color;                 // field
        int maxSpeed;                 // field
        public void fullThrottle()    // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.fullThrottle();  // Call the method
        }
    }
    */

    /*******************  9. using multiple classes *****************/
    class Car
    {
        public string model;
        public string color;
        public int year;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }








}

