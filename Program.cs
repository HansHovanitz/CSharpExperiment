using System;

namespace CSharpExperiment
{
    class Program
    {        
        const string BREAK = "---------------------------------";

        //C# is OOP: Object Oriented Programming.
        //A blueprint for a house design is like a class description (the House class file). 
        //All the houses built from that blueprint are objects of that class. 
        //A given house is an instance.

        //For now it's probably easiest to think of "objects" and "instances" as
        //basically the same thing. A new object is an instance of its class.
        //In this example each new House object is an instance of the House class. 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Houses(); //Why do you have this here? Is it because you created a method that did all the work?
            //I guess I usually put all the work in the Main() method.  
            //-JEFF
            /*-----------------------
            //Good question. You totally _could_ put everything in the main method. 
            //Once your program starts to get bigger it will become unwieldy if you have everything in one method though. 
            //You will miss out on many of the advantages of OOP like reusability and encapsulation. 
            //The Main method is the required "entry point" into the program but that's basically all it has to be -- 
            //the program will be more organized if you break it up into different methods and 
            //eventually classes (different objects, since C# is an object oriented programming language). 
            //It might not make total sense now, but embrace the process and practice doing it. 
            //Down the road the picture will start to become more clear and you'll start to see the strengths of this style of programming. 
            //-HANS
            -----------------------*/

            //To keep the console open if using Visual Studio. 
            Console.ReadKey();
        }

        static void Houses(){
            //Creating a new house object. We are passing the color blue and the size of 1500
            //to the constructor. 
            House house1 = new House("blue", 1500);

            //We can display the info about house1 a few different ways (houseInfo() is a
            //method that is defined in the House class):
            //Set the info to a variable and then display it:
            string myHouse = house1.houseInfo();
            Console.WriteLine(myHouse);
            //Or we could just do it directly:
            Console.WriteLine(house1.houseInfo());
            Console.WriteLine(BREAK);

            //house1 is looking kind of old. We should give it a new paint job:
            house1.setColor("green");

            //Now house1 is green.
            Console.WriteLine("We changed the color of the house:\n" + house1.houseInfo());
            Console.WriteLine(BREAK);

            //Creating a new house object.
            House house2 = new House("purple", 1800);

            //Now we have two different instances of the House class: house1 and house2. 
            //They are both the same type, which is House, but they have different values
            //like color and sqft. However, they BOTH have the same utilities value because
            //that variable is static, meaning that it is the same for all of our House objects. 
            //It makes sense for that value to be static because all houses need electricity.
            Console.WriteLine(house1.houseInfo());
            Console.WriteLine(house2.houseInfo());
            Console.WriteLine(BREAK);
        }
    }
}
