namespace Race;

public class Car : Vehicle
{
    /// <summary>
    /// Constructor for Car.
    /// Same value for a basic vehicle. But
    /// _acceleration should be equal to 0.5
    /// _weight should be equal to 0.5
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="color"></param>
    public Car(double speed, ConsoleColor color) : base(speed, color)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// If the Car is broken down then decrease the _broke value by one.
    /// If isnt, then move the car by changing the position to the new position.
    /// Then check whether the Car has broke down.
    /// A car break down in a Turn if the luck value is lower than 40 (excluded)
    /// A car break down elsewhere if the luck value is lower than 20 (excluded)
    /// </summary>
    /// <param name="newPosition"></param>
    /// <param name="track"></param>
    /// <param name="luck"></param>
    /// <returns></returns>
    public override bool Move(uint newPosition, Track track, int luck)
    {
        throw new NotImplementedException();
    }

    public override void Print()
    {
        Console.ForegroundColor = color;
        Console.Write("Car");
        Console.ForegroundColor = ConsoleColor.Black;
    }
}