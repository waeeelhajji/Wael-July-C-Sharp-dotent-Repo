class Chair : Furniture
{
    //!Fields

    private int numLegs;
    public int _numLegs { get { return numLegs; } }

    //! Constructor
    public Chair(string m, string c, double p, bool o, int n) : base(m, c, p, o)
    {
        numLegs = n;
    }

    //? OverRide Methods
    public override void ChangeColor(string newColor)
    {
        Console.WriteLine($"Changed our Chair from {color} to {newColor}");
        color = newColor;
    }




}