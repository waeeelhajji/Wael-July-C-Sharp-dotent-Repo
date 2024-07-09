class Furniture
{
    //! Fields  Describe our Object
    private string material;
    public string _material { get { return material; } }
    public string color;
    public double price;
    public bool outdoor;



    //! Constructor 
    public Furniture(string m, string c, double p, bool o)
    {
        material = m;
        color = c;
        price = p;
        outdoor = o;
    }
    // public Furniture(string m, string c, double p, bool o = true)
    // {
    //     material = m;
    //     color = c;
    //     price = p;
    //     outdoor = o;
    // }
    public Furniture(string m, string c, bool o)
    {
        material = m;
        color = c;
        price = 5.00;
        outdoor = o;
    }

    //? Methods
    public virtual void ChangeColor(string newColor)
    {
        Console.WriteLine($"Changed our Furniture from {color} to {newColor}");
        color = newColor;
    }


}



