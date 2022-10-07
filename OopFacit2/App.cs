namespace OopFacit2;

public class App
{
    public void Run()
    {
        var stefan = new Person(new DateTime(1972, 8, 3));
        stefan.ChangeAddress("Testgatan 12", "11122", "Teststad");
        var oliver = new Person(new DateTime(2008, 5, 28));
        oliver.ChangeAddress("Andra gatan 11", "22211", "Staden");
        Console.WriteLine($"{oliver.StreetAddress} {oliver.PostalCode} {oliver.City}");

        oliver.MoveInto(stefan);

        Console.WriteLine($"{oliver.StreetAddress} {oliver.PostalCode} {oliver.City}");
    }
}