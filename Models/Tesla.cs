namespace Garage;

public class Tesla : Vehicle  // Electric car
{
    public double BatteryKWh { get; set; }
    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine("The Burgundy Tesla blazes by you. MMmmmmmmmm!");
    }
}