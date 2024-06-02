namespace Garage;

public class Vehicle
{
    public string? MainColor;
    public int MaximumOccupancy;
    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }
    public virtual void Turn(string direction, string vehicle, string adjective)
    {
        Console.WriteLine($"The {vehicle} {adjective} turns {direction}");
    }
    public virtual void Stop(string adjective)
    {
        Console.WriteLine($"The vehicle {adjective} rolls to a stop");
    }
}