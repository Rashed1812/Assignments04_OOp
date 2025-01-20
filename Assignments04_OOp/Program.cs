namespace Assignments04_OOp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1.Write a class named Calculator that contains a method named Add. Overload the Add method to:

            //Calculator cal1 = new Calculator();
            //Console.WriteLine(cal1.Add(1, 2));
            //Console.WriteLine(cal1.Add(1, 2, 3));
            //Console.WriteLine(cal1.Add(1.5, 2.5)); 

            #endregion

            #region 2.Create a class named Rectangle with the following constructors:

            //Rectangle rec1 = new Rectangle();
            //Rectangle rec2 = new Rectangle(5, 10);
            //Rectangle rec3 = new Rectangle(30);

            //Console.WriteLine($"Rectangle one: Width = {rec1.Width}, Height = {rec1.Height}");
            //Console.WriteLine($"Rectangle Two: Width = {rec2.Width}, Height = {rec2.Height}");
            //Console.WriteLine($"Rectangle Three: Width = {rec3.Width}, Height = {rec3.Height}"); 

            #endregion

            #region 3.Define a class Complex Number that represents a complex number with real and imaginary parts.

            //ComplexNumber c1 = new ComplexNumber(10, 20);
            //ComplexNumber c2 = new ComplexNumber(5, 6);

            //ComplexNumber sum = c1 + c2;
            //ComplexNumber difference = c1 - c2;

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Difference: {difference}"); 

            #endregion

            #region 4.Create a derived class named Manager that overrides the Work method to print "Manager is managing". 

            //Employee e1 = new Employee();
            //e1.Work();

            //Manager m1 = new Manager();
            //m1.Work(); 

            #endregion

            #region 5.Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass".

            ////The method that gets called depends on the runtime type of the object (Runtime Blinding)
            //BaseClass base1 = new DerivedClass1();
            //base1.DisplayMessage();

            //// from BaseClass (compile-time binding)
            //BaseClass base2 = new DerivedClass2();
            //base2.DisplayMessage();

            ////from DerivedClass2
            //DerivedClass2 derived2 = new DerivedClass2();
            //derived2.DisplayMessage(); 

            #endregion

        }
    }
}
