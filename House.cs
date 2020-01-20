using System;

namespace CSharpExperiment
{
    //This is the name of the class. It should match the name of the file (House).
    class House
    {
        //These are the instance variables. The values could be different for each new House object 
        //(instance of the House class) that we create. 
        private string color;
        private int size;

        //This is a class variable. It is static because it will remain the same for all House objects 
        //(instances of the class House) that we create. For the purpose of this example we are saying 
        //all houses need electricity and get it from a utility company. 
        public static string utilities = "electricity";

        //This is the constructor method. It should be the same name as the class. It is used to 
        //create new objects of the House class. This method gets automatically invoked when we use
        //the 'new' keyword. (Invoking basically means it is getting called automatically).
        public House(string color, int size) {
            //We use the 'this' keyword to differentiate between the method parameters and 
            //the class' instance variables. 
            //(string color, int size)  <--- those are the method parameters. 
            this.color = color;
            this.size = size; 
        }

        //This is a setter/mutator method. Its purpose is to set the color 0f a House after
        //its initial construction. 
        public void setColor(string color) {
            this.color = color;
        }

        //This is a getter/accessor method. Its purpose is to get the color of a House. 
        public string getColor() {
            return color;
        }

        //A get method for utilities. We only need a getter/accessor here and not a setter/mutator
        //because the value of the utilities variable will never change across all instances of the
        //different houses that may get created. 
        public string getUtilities() {
            return utilities;
        }

        //A method that gives us details about the house. 
        //In this method we use the "get" methods that were set up above to access this class' variables.
        //We can also directly access the variable because this method is within the same class as the variable
        //(and the variable is within scope). We are getting the value of color with the former and the value
        //of size with the latter. 
        public string houseInfo() {
            string info = "This house is the color: " + getColor() + "\nThe size of the house is: " +
                + size + " sqft\nRequired Utilities: " + getUtilities();
            return info;
        }
    }
}