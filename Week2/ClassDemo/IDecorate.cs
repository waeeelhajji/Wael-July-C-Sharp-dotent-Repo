interface IDecorate
{
    //-------------------(auto-implemented property)
    List<string> AllItems { get; set; }
    int numberOfItems { get; set; }

    void AddItems(string Item);
    void ShowDecorations();
}