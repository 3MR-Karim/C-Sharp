using Assignment_03_OOP.Qustion_2;
using Assignment_03_OOP.Qustion_3;

namespace Assignment_03_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Q1
            /*What is the primary purpose of an interface in C#?
                a) To provide a way to implement multiple inheritance
                b) To define a blueprint for a class
                c) To declare abstract methods and properties
                d) To create instances of objects
            */
            // Answer A
            #endregion

            #region Q2
            /*Which of the following is NOT a valid access modifier for interface members in C#?
                a) private
                b) protected
                c) internal
                d) public
            */
            // Answer A
            #endregion

            #region Q3
            /*
             Can an interface contain fields in C#?
                a) Yes
                b) No
                c) Only if they are static
                d) Only if they are read only

             */
            // Answer B
            #endregion

            #region Q4
            /*
             In C#, can an interface inherit from another interface?
                a) No, interfaces cannot inherit from each other
                b) Yes, interfaces can inherit from multiple interfaces
                c) Yes, but only if they have the same methods
                d) Only if the interfaces are in the same namespace
             */
            // Ansewr B
            #endregion

            #region Q5
            /*
             Which keyword is used to implement an interface in a class in C#?
                a) inherit
                b) use
                c) extends
                d) implements
            */
            // Answer D
            #endregion

            #region Q6
            /*
             Can an interface contain static methods in C#?
                a) Yes
                b) No
                c) Only if the interface is sealed
                d) Only if the methods are private
             */
            // Answer B
            #endregion

            #region Q7
            /*
             In C#, can an interface have explicit access modifiers for its members?
                a) Yes, for all members
                b) No, all members are implicitly public
                c) Yes, but only for abstract members
                d) Only if the interface is sealed
             */
            // Answer B
            #endregion

            #region Q8
            /*
             What is the purpose of an explicit interface implementation in C#?
                a) To hide the interface members from outside access
                b) To provide a clear separation between interface and class members
                c) To allow multiple classes to implement the same interface
                d) To speed up method resolution
             */
            // Answer B
            #endregion

            #region Q9
            /*
             In C#, can an interface have a constructor?
                a) Yes, but it must be private
                b) No, interfaces cannot have constructors
                c) Yes, but only if the interface is sealed
                d) Only if the constructor is static
             */
            // Answer B
            #endregion

            #region Q10
            /*
             How can a C# class implement multiple interfaces?
                a) By using the "implements" keyword
                b) By using the "extends" keyword
                c) By separating interface names with commas
                d) A class cannot implement multiple interfaces
             */
            // Answer A
            #endregion
            #endregion

            #region Video Number 5 Task
            /*
             How Deep Copy Uses Shallow Copy:

             When performing a deep copy, the deepcopy function first creates a shallow copy of the object.
             Then, it goes through the shallow copy and recursively deep copies the objects found within it.

             This ensures that all nested objects are also copied.
             Here’s a simplified overview of how deepcopy works:
              1. Create a shallow copy of the original object.
              2. Recursively deep copy all referenced objects found within the shallow copy.
              3. Replace references in the shallow copy with references to the deep copies of the objects.
             */
            #endregion

            #region Part 02
            #region Q1
            //Circle C1 = new Circle();
            //C1.Raduis = 10;
            //C1.DisplayShapeInfo();

            //Rectangle R1 = new Rectangle();
            //R1.Width = 10;
            //R1.Height = 5;
            //R1.DisplayShapeInfo();

            #endregion

            #region Q2
            // Create an instance of BasicAuthenticationService
            //IAuthenticationService authService = new BasicAuthenticationService();

            //// Authenticate a user
            //bool isAuthenticated = authService.AuthenticateUser("user1", "password1");
            //Console.WriteLine("User authenticated: " + isAuthenticated);

            //// Authorize a user
            //bool isAuthorized = authService.AuthorizeUser("user1", "admin");
            //Console.WriteLine("User authorized: " + isAuthorized);
            #endregion

            #region Q3
            //INotificationService notificationEmail = new EmailNotificationService();
            //INotificationService notificationSms = new SmsNotificationService();
            //INotificationService notification = new PushNotificationService();

            //notificationEmail.SendNotification("email@example.com", "Hello via Email!");
            //notificationSms.SendNotification("123-456-7890", "Hello via SMS!");
            //notification.SendNotification("Message For", "You Have A Notification Check it");
            #endregion

            #endregion
        }
    }
}
