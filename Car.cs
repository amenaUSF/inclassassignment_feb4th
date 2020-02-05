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
    /*class Car
    {
        public string model;
        public string color;
        public int year;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
    */

    /********************** 10 . constructors **************************/
    // Create a Car class
    /*  class Car
      {
          public string model;  // Create a field

          // Create a class constructor for the Car class
          public Car()
          {
              model = "Mustang"; // Set the initial value for model
          }

          static void Main(string[] args)
          {
              Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
              Console.WriteLine(Ford.model);  // Print the value of model
          }
      }*/

    /********************** 11. constructors with multiple parameters **************************/
    /*    class Car
        {
            public string model;
            public string color;
            public int year;

            // Create a class constructor with multiple parameters
            public Car(string modelName, string modelColor, int modelYear)
            {
                model = modelName;
                color = modelColor;
                year = modelYear;
            }

            static void Main(string[] args)
            {
                Car Ford = new Car("Mustang", "Red", 1969);
                Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
            }
        }*/

    /***************** 12. Private Modifier *******************/
    /*  class Car
       {
           private string model;

           public Car(string modelName)
           {
               model = modelName;
           }
           static void Main(string[] args)
           {
               Car Ford = new Car("Mustang");
               Console.WriteLine(Ford.model);
           }
       }
       */

    /******************* 13. Public Modifier **************************/

    /*  class Car
      {
          public string model = "Mustang";
      }

      class Program
      {
          static void Main(string[] args)
          {
              Car myObj = new Car();
              Console.WriteLine(myObj.model);
          }
      }
      */

    /********************** 16. inheritance ************************/
    /*    class Vehicle  // base class (parent) 
        {
            public string brand = "Ford";  // Vehicle field
            public void honk()             // Vehicle method 
            {
                Console.WriteLine("Tuut, tuut!");
            }
        }

        class Car : Vehicle  // derived class (child)
        {
            public string modelName = "Mustang";  // Car field
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Create a myCar object
                Car myCar = new Car();

                // Call the honk() method (From the Vehicle class) on the myCar object
                myCar.honk();

                // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
                Console.WriteLine(myCar.brand + " " + myCar.modelName);
            }
        }
        */

   /********************* 17. inheritance 2 ***********************/
/*    class Animal  // Base class (parent) 
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
*/

        /************************* 18. Inheritance with virtual and override *****************************/
class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }

    /*******************************************/



}

