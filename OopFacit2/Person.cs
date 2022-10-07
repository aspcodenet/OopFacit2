namespace OopFacit2;

public class Person
{
    private DateTime _birthDate;
    private string _name;
    private string _streetAddress;
    private string _postalCode;
    private string _city;

    public Person(DateTime birthDate)
    {
        _birthDate = birthDate;
    }
    public string Name
    {
        get { return _name;}
        set { _name = value; }
    }
    public string StreetAddress
    {
        get { return _streetAddress; }
    }
    public string PostalCode
    {
        get { return _postalCode; }
    }
    public string City
    {
        get { return _city; }
    }

    public void ChangeAddress(string newStreetAddress, string newPostalCode, string newCity)
    {
        _streetAddress = newStreetAddress;
        _postalCode = newPostalCode;
        _city = newCity;
    }

    public void MoveInto(Person p)
    {
        ChangeAddress(p.StreetAddress, p.PostalCode, p.City);
    }

}