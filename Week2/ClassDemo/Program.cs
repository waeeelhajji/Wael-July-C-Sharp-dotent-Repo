
Chair PlasticChair = new Chair("Wood", "Brown", 5.00, false, 4);
// Furniture ExmpFurniture = new Furniture("Iron", "red", 7.00, false);
// Chair.material = "Iron";
Console.WriteLine(PlasticChair._material);


Chair Stool = new Chair("Velvet", "Red", 500.000, false, 5);
Console.WriteLine(Stool._numLegs);
PlasticChair.ChangeColor("Blue");
Stool.ChangeColor("Yellow");


Furniture OutdoorTable = new Table("Plastic", "White", 100.00, true);



//? Polymorphism

List<Furniture> AllFurniture = new List<Furniture>();

AllFurniture.Add(Stool);
AllFurniture.Add(OutdoorTable);
AllFurniture.Add(PlasticChair);

List<Chair> AllChair = new List<Chair>();
AllChair.Add(PlasticChair);
AllChair.Add(Stool);


// ! New Polymorphism

List<Furniture> _ = new

List<Furniture>()
{
    PlasticChair,
    Stool
};


//? Interfaces
Table newTable = new Table("Wood", "Magenta", 800.564, false, 5);
Console.WriteLine(newTable.numberLegs);

newTable.AddItems("TableCloth");
newTable.AddItems("Plate set");
newTable.AddItems("vase");

Console.WriteLine(newTable.numberOfItems);

newTable.ShowDecorations();












