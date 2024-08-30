using Demo.Inheritance;
namespace Demo
{
    #region Relationship Between Classes
    //class Order
    //{
    //    // Aggregation Relationship
    //    public Item[] Items { get; set; }
    //} 

    //class Item
    //{

    //}
    //class Room
    //{
    //    //Composition Relationship [Requird]
    //    public Wall Wall { get; set; }
    //    // Assosiation Relationship [Optional]
    //    public Chair[]? chairs { get; set; }
    //}
    //class Chair
    //{

    //}
    //class Wall
    //{

    //} 
    #endregion
    internal class Program
    {
        #region Polumorphism - Method Overloading
        //static int sum(int X , int Y)
        //{
        //    return X + Y;
        //}

        //static double sum(double X, double Y)
        //{
        //    return X + Y;
        //}

        //static int sum(int X, int Y,int z)
        //{
        //    return X + Y;
        //}

        //static double sum(int X, double Y)
        //{
        //    return X + Y;
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region Inheritance
            ////Inheritace
            //// Class ---> Class
            //// Dry : Do not Repeat Your self


            //Child child = new Child(1, 2);
            //child.X = 12;
            //child.Y = 13;

            //child.Fun01();
            //child.Fun02(); 

            //// This Behavior not inheritance Something like inheritance
            //child.ToString(); 
            #endregion

            #region Relationship Between Classes
            // Relationship Between Classes

            // 1. Inheritance : is a Relationship [FullTimeEmployee is a Employee - Dog is a Animal]
            // 2. Aggregation : has a Relationship
            // 2.1 Compostition: Mean Relation is Required
            // 2.1 Assosiation : Mea Relation is Optional 
            #endregion

            #region Polymorphism
            // Pillers Number 3
            // Polymorphism
            // 1. Polymorphism - Method Overloading
            // 2. Polumorphism - Method Overrididng
            // Function Or method have more than one face

            // Have 18  Overloading
            //Console.WriteLine();

            //Object O1;
            //O1 = new Object();
            //O1 = "Ahmed";
            //O1 = 1;
            //O1 = 1.4;
            //O1 = 1.4f;
            //O1 = 1.4m; 
            #endregion

            #region Polymorphism - Method Overloading
            // 1. Polymorphism - Method Overloading
            // More Than one func [in the same scope] has same name but different signature [count , type , order] parameter]
            // in same scope mean in same class or struct
            // overloading supported in class and struct
            // struct support only Encapsulation and Method Overloading.

            //sum(1, 2);
            //sum(1.5,1.3);
            //sum(1,2,3);
            //sum(1, 1.5);
            //sum(1.5, 1); // double , double 

            //sum()
            #endregion

            #region Ploymorphism - Method [Function] Overriding
            // 2. Ploymorphism - Method [Function] Overriding
            // More Than One Function  [in Different Class] Has The Same Name and The Same Signature 
            // But With Different Behaviours in different Class

            //TypeB typeB = new TypeB(1,2);
            //typeB.A = 11;
            //typeB.B = 11;

            //typeB.Fun01(); 
            //typeB.Fun02(); 
            #endregion

            #region What Is Binding
            //// Binding
            //// ReferenceFormParent ---> Object From Child

            //TypeA typeA;
            ////typeA = new TypeA(1);
            //typeA = new TypeB(1,2);

            //typeA.A = 12;
            ////typeA.B = 11;

            //typeA.Fun01();
            //typeA.Fun02(); 
            #endregion

            #region No Binding
            // Binding 

            // ReferenceFromParent --> ObjectFromChiled

            //TypeA typeA;
            //typeA = new TypeA(1);
            //typeA = new TypeB(1, 2);
            ////typeA = new TypeC(1,2,3)

            //TypeB typeB = (TypeB)typeA; // No Binding
            //typeB.B = 12;

            // TypeB --> TypeA [TypeB is a TypeA]

            // Animal --> Dog -- Dog is a Animal

            // Dog --> (Dog) Animal no binding 
            #endregion





        }
    }
}
