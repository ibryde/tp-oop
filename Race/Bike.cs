namespace Race;

public class Bike : Vehicle
{
    /// <summary>
    /// Constructor for Bike.
    /// Same value for a basic vehicle. But
    /// _acceleration should be equal to 0.7
    /// _weight should be equal to 0.2
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="color"></param>
    public Bike(double speed, ConsoleColor color) : base(speed, color)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// When a bike break down. It is broken down for longer than any other vehicle.
    /// The _broke value should be equal to 5.
    /// </summary>
    public override void BrokeDown()
    {
        throw new NotImplementedException();
    }

    /// If the Bike is broken down then decrease the _broke value by one.
    /// If isnt, then move the car by changing the position to the new position.
    /// Then check whether the Car has broke down.
    /// A bike break down in a Turn if the luck value is lower than 60 (excluded)
    /// A bike break down elsewhere if the luck value is lower than 30 (excluded)
    public override bool Move(uint newPosition, Track track, int luck)
    {
        throw new NotImplementedException();
    }

    public override void Print()
    {
        Console.ForegroundColor = color;
        Console.Write("Bike");
        Console.ForegroundColor = ConsoleColor.Black;
    }
}