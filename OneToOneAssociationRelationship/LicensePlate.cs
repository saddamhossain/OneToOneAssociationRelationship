namespace OneToOneAssociationRelationship;

public class LicensePlate
{
    public string PlateNumber { get; private set; }
    public DateTime RegistrationDate { get; private set; }
    public DateTime ExpirationDate { get; private set; }

    public LicensePlate(string plateNumber, DateTime registrationDate, DateTime expirationDate)
    {
        PlateNumber = plateNumber;
        RegistrationDate = registrationDate;
        ExpirationDate = expirationDate;
    }

    public bool IsLicensePlateValid()
    {
        return ExpirationDate > DateTime.Now;
    }
}