namespace PriceDBSpace
{
    public class PriceDB
    {   // Declare internal instance array of Price structures.
        // Initiate by one Price structure.
        private readonly Price[] _arrPrice = new Price[1];

        // Declare internal array index.
        public Price this[int index]
        {
            get
            {
                return _arrPrice[index];

            }
        }

        /// <summary>
        /// Creates an object as an array of Prices, read data, 
        /// check property Cost with Exception.
        /// </summary>
        /// <param name="numPrices"></param>
        public PriceDB(int numPrices)
        {
            _arrPrice = new Price[numPrices];

            for (int i = 0; i < _arrPrice.Length; i++)
            {
                _arrPrice[i] = new Price();

                Console.Write($"Price{i + 1}.Name:");
                _arrPrice[i].Name = Console.ReadLine();
                Console.WriteLine();

                Console.Write($"Price{i + 1}.Store:");
                _arrPrice[i].Store = Console.ReadLine();
                Console.WriteLine();

                Console.Write($"Price{i + 1}.Cost:");

                // Check property Year with Exception.
                try
                {
                    _arrPrice[i].Cost = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Cost should be decimal: {e.Message}");
                    _arrPrice[i].Cost = 0.0m;
                }

                Console.WriteLine("");

                Console.Clear();
            }
        }

        /// <summary>
        /// Shows elements of the structures array.
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"PriceDB consists {_arrPrice.Length} Prices.");
            Console.WriteLine(new string('=', 100));
            for (int i = 0; i < _arrPrice.Length; i++)
            {
                Console.WriteLine($"Price {i + 1} - Name: {_arrPrice[i].Name}\tSurename: {_arrPrice[i].Store}" +
                    $" \tYear: {_arrPrice[i].Cost}  ");
                Console.WriteLine(new string('=', 100));
            }
        }

        /// <summary>
        /// Sorts elements of array of the Price structures 
        /// by alphabetical order of Name property.
        /// </summary>
        public void SortABC()
        {
            int numPass = _arrPrice.Length - 1;
            int adressLastBuble = _arrPrice.Length - 1;
            int replace = 1;
            int chSmaller;

            for (int k = 0; k < numPass; k++)
            {
                for (int i = 0; i < numPass; i++)
                {
                    if (replace != 0) //If there was replaces
                    {
                        replace = 0;
                        for (int j = 0; j < adressLastBuble; j++)
                        {
                            chSmaller = _arrPrice[j].CompareTo(_arrPrice[j + 1]);

                            if (chSmaller > 0)
                            {
                                Price buffer = _arrPrice[j + 1];
                                _arrPrice[j + 1] = _arrPrice[j];
                                _arrPrice[j] = buffer;
                                replace++;
                            }
                        }
                    }
                }
            }
            Show();

            Console.WriteLine($"PriceDB has been sorted by alphabetical order successfully!");
        }

        /// <summary>
        /// Shows Price elements what has expensive than cost.
        /// </summary>
        /// <param name="cost"></param>
        public void ShowExpensive(int cost)
        {

            Console.WriteLine($"\nPriceDB consists Prices what is expensive than {cost}:");
            Console.WriteLine(new string('=', 100));
            for (int i = 0; i < _arrPrice.Length; i++)
            {
                if (_arrPrice[i].Cost > cost)
                {
                    Console.WriteLine($"Price {i + 1} - Name: {_arrPrice[i].Name}");
                }
            }
        }

        /// Shows the best Price by indexer.
        public void ShowBest(int indexPrice)
        {
            if (indexPrice > 0 && indexPrice < _arrPrice.Length)
            {
                Console.WriteLine($"\n\nThe best Price of the year is: " +
                            $"{this[indexPrice].Name} {this[indexPrice].Store}  {this[indexPrice].Cost}!");
            }
            else
            {
                Console.WriteLine($"The index of the best Price is wrong!");
            }
        }
        public void ShowGoods(string store)
        {
            try
            {

                int storeExists = 0;
                for (int i = 0; i < _arrPrice.Length; i++)
                {
                    if (_arrPrice[i].Store == store) storeExists++;
                }
                if (storeExists != 0)
                {
                    Console.WriteLine($"List of goods - Store {store}:");
                    foreach (var price in _arrPrice)
                    {

                        if (price.Store == store)
                        {
                            Console.WriteLine($"Store:{price.Store}\t Price:{price.Name}\t Store:{price.Cost}");
                        }
                    }
                }
                else
                {
                    throw new PriceException();
                }
            }
            catch (PriceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}

