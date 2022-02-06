public struct Price : IComparable
{
    // Declare default values of fields of a structure.
    private string _name = "None";
    private string _store = "None";
    private decimal _cost = 0.0m;

    // Declare properties of a structure. 
    public string Name { get { return _name; } set { _name = value; } }
    public string Store { get { return _store; } set { _store = value; } }
    public decimal Cost { get { return _cost; } set { _cost = value; } }

    public Price(string name, string store, decimal cost)
    {
        _name = name;
        _store = store;
        _cost = cost;

    }

    // Implement IComparable interface to realize method CompareTo()
    // to compare Price structures by their properties values.
    /// <summary>
    /// Compares Price structures by Name property.
    /// </summary>
    /// <param name="otherObj"></param>
    /// <returns> 
    /// Less than zero - This instance precedes obj in the sort order.
    /// Zero - This instance occurs in the same position in the sort order as obj.
    /// Greater than zero - This instance follows obj in the sort order. 
    /// </returns>

    public int CompareTo(object? otherObj)
    {
        Price other = (Price)otherObj;
        if (otherObj == null)
        {
            return 0;
        }
        return (int)string.Compare(this.Name, other.Name);
    }
}

