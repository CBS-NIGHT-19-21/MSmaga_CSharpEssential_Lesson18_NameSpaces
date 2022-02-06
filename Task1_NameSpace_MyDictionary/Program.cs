using PriceDBSpace;
class Program
{
    static void Main()
    {
        #region Задание 1 NameSpace

        //Используя пример выполненного домашнего задания 3 из 15 урока, реализуйте возможность
        //подключения вашего пространства имен и работы с MyDictionary<TKey, TValue> аналогично
        //экземпляру класса Dictionary< TKey,TValue >.

        #endregion

        // Create array of Price objects.
        PriceDB PriceDB = new(2);

        // Show elements of array.
        PriceDB.Show();

        // Sort elements of array by ABC.
        PriceDB.SortABC();

        // Show Prices who is experienced greater than 2005.
        PriceDB.ShowExpensive(1319);

        // Show the best Price by indexer.
        PriceDB.ShowBest(1);

        PriceDB.ShowGoods("Main");

        //Delay.
        Console.ReadLine();
    }
}





