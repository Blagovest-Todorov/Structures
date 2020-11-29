using System;

namespace _09.Structures
{
    class Program
    {

        struct Point 
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

        }

        static void Main(string[] args)
        {

            //Structures are similar to classes, 
            //but structures are value type, -> hold direectly a value
            //classes a referent type-pointers
            //structures can have fields, properties, ets, using mehtods is not recommended
            //exmaple of structure is System.DateTime--represent a date and time//
            //Structures can have a mthoeds here but is not recommended
            // structure  behave like a usual class//

            //Structures when we do a thing does not have a behavior, --there is not a functionallity; 
            //the classes allow behaviour, structures does not allow to have behaviour--behavour is functionallity ! 
            //the point symbpol . "." --has only coordinates x, y, z --does not have a functioanllity, 
            //the .  dont do anithing--so the  "." is a structure

            //Point p = new Point(); //initalizing values
            //p.X = 1;
            //p.Y = 12;

            Point p = new Point  //another way to define  a value to initialize
            {
                X = 1, 
                Y = 2, 
                Z = 3
              
            
            };

            
            
        }
    }
}
