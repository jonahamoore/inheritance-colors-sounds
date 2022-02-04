using System;

namespace Garage
{
public class Tesla : Vehicle  // Electric car
{
    public double BatteryKWh { get; set; }
    // public string MainColor { get; set; }
    // public string MaximumOccupancy { get; set; }
    public void ChargeBattery()
    {
        // method definition omitted
    }

    public override void Drive ()
    {
        Console.WriteLine($"The {MainColor} Tesla blazes by you. MMmmmmmmmmmm!");
    }
}


}