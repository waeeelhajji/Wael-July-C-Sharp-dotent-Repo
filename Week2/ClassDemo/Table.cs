class Table : Furniture, IDecorate
{

    public int numberLegs;
    public int numberOfItems { get; set; }
    public List<string> AllItems { get; set; }
    public Table(string m, string c, double p, bool o, int nl = 4) : base(m, c, p, o)
    {
        numberLegs = nl;
        numberOfItems = 0;
        AllItems = new List<string>();

    }

    public void AddItems(string Item)
    {
        numberOfItems++;
        AllItems.Add(Item);
        Console.WriteLine($"Placed a {Item} on the Table");
    }
    public void ShowDecorations()
    {
        foreach (string item in AllItems)
        {
            Console.WriteLine(item);
        }
    }

}