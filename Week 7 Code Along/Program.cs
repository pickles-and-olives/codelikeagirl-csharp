// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
var pet1 = new Pet
{
    animal = "cat",
    name = "Sooty",
    age = 4,
};
//Console.WriteLine($"A {pet1.age} year old {pet1.animal} named {pet1.name} is available for adoption!");
//pet1.displayDetails();

var pet2 = new Pet();
pet2.animal = "dog";
pet2.name = "Lola";
pet2.age = 2;

//Console.WriteLine($"A {pet2.age} year old {pet2.animal} named {pet2.name} is available for adoption!");
//pet2.displayDetails();

var pet3 = new Pet();
pet3.animal = "tortoise";
pet3.name = "Esiotrot";
pet3.age = 18;

//pet3.displayDetails();

var pets = new List<Pet>
{
pet1, pet2, pet3
};

foreach(var pet in pets)
{
pet.displayDetails();
}

var headOffice =new Address
{
streetNumber = "33b",
streetName = "Rosebank Rd",
city = "Auckland",
postcode = 1026
};

var regionalOffice =new Address
{
streetNumber = "87",
streetName = "Portland Rd",
city = "Auckland",
postcode = 1020
};

var southIslandOffice =new Address
{
streetNumber = "7",
streetName = "Reiding St",
city = "Nelson",
postcode = 7020
};

var headOfficeAddress = headOffice.getAddress();
var regionalOfficeAddress = regionalOffice.getAddress();
var southIslandOfficeAddress = southIslandOffice.getAddress();

Console.WriteLine($"Our head office is loacated at {headOfficeAddress} and our regional office is located at {regionalOfficeAddress}, if you are in the south island, please go to {southIslandOfficeAddress}.");



public class Pet
{
    public string? animal;
    public string? name;
    public int age;

    public void displayDetails()
    {
        Console.WriteLine($"A {age} year old {animal} named {name} is available for adoption!");
    }
}

public class Address
{
    public string? streetNumber;
    public string? streetName;
    public string? city;
    public int postcode;

    public string getAddress()
    {
        return $"{streetNumber} {streetName}, {city}";
    }
}


