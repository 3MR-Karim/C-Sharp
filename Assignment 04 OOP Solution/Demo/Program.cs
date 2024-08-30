namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction
            // Abstraction : No details in the information
            // abstract C# Keyword [Class - Methods - Property]

            //Shape shape = new Shape();
            //shape.GetArea();

            // Can`t Create Object From Abstract Class

            //Rectangle rectangle = new Rectangle();

            //rectangle.Dim01 = 3;
            //rectangle.Dim02 = 4;

            //Console.WriteLine(rectangle.Premeter);
            //Console.WriteLine(rectangle.GetArea());

            //Square square = new Square();
            //square.Dim01 = 5;
            //square.Dim02 = 5;

            //Console.WriteLine(square.Premeter);
            //Console.WriteLine(square.GetArea()); 
            #endregion

            #region Operator Overloading
            //// Operator Overloading
            //// + - * & ^  / %
            //// Make Another version of operator with new behaviour

            //// Complex Number

            //Complex C1 = new Complex() { Real = 8 , Imag = 2 };
            //Complex C2 = new Complex() { Real = 5 , Imag = 6 };

            ////Console.WriteLine(C1);
            ////Console.WriteLine(C2);


            ////Complex C3 = C1 + C2;

            ////Console.WriteLine(C3);


            ////// ++ Operator

            ////C1++;
            ////Console.WriteLine(C1);

            //// > < == <= >= !=
            ////if(C1 > C2)
            ////{
            ////    Console.WriteLine("C1 is Greater Than C2");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("C1 Is no Greater than C2");
            ////} 
            #endregion

            #region Interface Vs Abstract

            #endregion

            #region Casting Operator Overloading
            // Casting Convert From Any Datatype To Any DataType
            // Explicit Cating
            //object O1 = 1;
            //int X = (int)O1;

            // Implicit Casting
            //int X = 2;
            //object O1 = X;

            //Complex C1 = new Complex() {Real = 2 , Imag = 3};

            //string S1 =/*(string)*/C1;
            //Console.WriteLine(S1);

            //// (string) Casting Operators

            //int X =(int)C1;

            // Manual Mapping
            // 1 . Code First
            // 2 . DB First 

            // User [Model = Table in DB]
            // UserViewModel [View Model]
            #endregion

            #region Static Keyword
            // Static C# KeyWord
            // Class - Methods - Property - Attribute - Constructor
            // Static Class
            // Static Method
            // Static Property
            // Static Attribute
            // Static Constructor

            //Utilities U1 = new Utilities();
            //Utilities U2 = new Utilities();
            //Utilities U3 = new Utilities();

            //Console.WriteLine(U1.CmToInch(254));
            //Console.WriteLine(U2.CmToInch(254));
            //Console.WriteLine(U3.CmToInch(254));

            //Console.WriteLine(Utilities.CmToInch(254));
            //Console.WriteLine(Utilities.CmToInch(254));
            //Console.WriteLine(Utilities.CmToInch(254));


            //Console.WriteLine(U1.PI);
            //Console.WriteLine(U2.PI);
            //Console.WriteLine(U3.PI);

            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI); 
            #endregion










        }
    }
}
