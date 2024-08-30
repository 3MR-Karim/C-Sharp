namespace Access_Modifires
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifires
            // Access Modifires :
            // 1. Public: Accessable From Anywhere
            // 2. Private: Accessable in same class or struct
            // 3. internal: Accessable anywhere in the same project
            // 4. Protected: Accessable in the same class and derived classes[child]
            // 5. Protected internal: Combination of Protected and internal A protected internal member is accessible from the current Project or from derived classes in other Projects.
            // 6. Private Protected: A private protected member is accessible within its containing class or types derived from the containing class, but only within its containing Projects.

            //Father father = new Father("AbdelSalam","Mansoura","Mohamed");
            //father.FamilyName = "Mohamed";
            //father.Work();
            ////father.FatherName can not access here because its protected just access in derived and same class
            ////father.Address; can not access because its a private

            //Son1 son1 = new Son1("Abdelsalam","Gamal");
            //son1.MyName = "Gamal";
            //son1.Work(); 
            #endregion

            #region Binding Example
            //Father father = new Son1("","");

            //father.FamilyName = "Mohamed";

            //father.Work(); // I Am A SoftWare Engineer
            //father.Habits(); // use new so compiler will call reference function --> I love Football
            #endregion
        }
    }
}
