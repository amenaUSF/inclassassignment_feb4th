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

    class Program
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

}

