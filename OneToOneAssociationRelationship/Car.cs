namespace OneToOneAssociationRelationship;

public class Car
{
    private const int MaxCarAgeForRenewal = 20;

    public string Owner { get; private set; }
    public string Manufacturer { get; private set; }
    public string Model { get; private set; }
    public int YearOfManufacturer { get; private set; }
    public LicensePlate LicensePlate { get; private set; }

    public Car(string owner, string manufacturer, string model, int yearOfManufacturer, LicensePlate licensePlate)
    {
        Owner = owner;
        Manufacturer = manufacturer;
        Model = model;
        YearOfManufacturer = yearOfManufacturer;
        LicensePlate = licensePlate;
    }

    public int GetCarAge()
    {
        return DateTime.Now.Year - YearOfManufacturer;
    }

    public bool IsEligibleForRegistrationRenewal()
    {
        return GetCarAge() <= MaxCarAgeForRenewal;
    }
}
