namespace Race;

public class Truck : Vehicle
{
    /// <summary>
    /// Constructor for Truck.
    /// Same value for a basic vehicle. But
    /// _acceleration should be equal to 0.3
    /// _weight should be equal to 0.8
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="color"></param>
    public Truck(double speed, ConsoleColor color) : base(speed, color)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// If the truck is broken down then decrease the _broke value by one.
    /// If it isnt, then move the truck by changing his position to the
    /// new position and check if the truck broke down.
    /// The truck broke down if the luck value is below 20 (excluded).
    /// </summary>
    /// <param name="newPosition"></param>
    /// <param name="track"></param>
    /// <returns></returns>
    public override bool Move(uint newPosition, Track track, int luck)
    {
        throw new NotImplementedException();
    }
    
    public override void Print()
    {
        Console.ForegroundColor = color;
        Console.Write("Truck");
        Console.ForegroundColor = ConsoleColor.Black;
    }
}