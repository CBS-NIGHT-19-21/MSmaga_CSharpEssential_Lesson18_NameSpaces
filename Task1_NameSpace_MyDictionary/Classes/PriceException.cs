class PriceException : Exception
{
    // Override the base field.
    public new string Message = "This store doesn`t exist!";

    // Inheritance Exception Class as Base Class.
    public PriceException() : base() { }
    
}

