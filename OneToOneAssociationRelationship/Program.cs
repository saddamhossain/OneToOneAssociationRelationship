LicensePlate licensePlate = new LicensePlate("ABCD", new DateTime(2020, 01, 01), new DateTime(2024, 10, 20));

Car car = new Car("Md. Saddam Hossain", "Toyota", "Corolla", 2005, licensePlate);

Console.WriteLine($"Car Owner: {car.Owner}");

Console.WriteLine($"Car: {car.Manufacturer} {car.Model}, Year: {car.YearOfManufacturer}");

Console.WriteLine($"Car Age: {car.GetCarAge()}");


if (car.IsEligibleForRegistrationRenewal())
{
    Console.WriteLine("The car is eligible for registration renewal.");
}
else
{
    Console.WriteLine($"The car is not eligible for registration renewal due to age.");
}

if (car.LicensePlate.IsLicensePlateValid())
{
    Console.WriteLine("The license plate is valid.");
}
else
{
    Console.WriteLine("The license plate is expired.");
}