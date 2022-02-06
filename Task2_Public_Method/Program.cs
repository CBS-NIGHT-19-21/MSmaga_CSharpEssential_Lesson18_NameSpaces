// Preprocessor command
#define V_1_0

using Library;
using PriceDBSpace;

class Program
{
    static void Main()
    {
        #region Задание 2

        //Создайте класс с методом помеченным модификатором доступа public. Докажите, что к данному
        //методу можно обратиться не только из текущей сборки, но и из производного класса внешней сборки.

        #endregion

#if (DEBUG && V_1_0)

        Console.WriteLine();
#endif
#line 123 // String of the error 123

#line hidden // Debuger - don`t use
        Console.WriteLine();
#line default

#warning Be careful
// #error My error
        // Link ClassLibrary1.
        Class1 instance = new();
        instance.PublicMethod();

        //instance.PrivateMethod();

        // Link PriceDBSpace.
        PriceDB PriceDB = new(2);
        PriceDB.Show();

        //Delay.
        Console.ReadLine();
    }
}