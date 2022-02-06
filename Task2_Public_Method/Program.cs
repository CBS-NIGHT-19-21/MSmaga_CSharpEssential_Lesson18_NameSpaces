
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

        // Link ClassLibrary1.
        Class1 instance = new ();
        instance.PublicMethod();
 
        //instance.PrivateMethod();

        // Link PriceDBSpace.
        PriceDB PriceDB = new(2);
        PriceDB.Show();

        //Delay.
        Console.ReadLine();
    }
}