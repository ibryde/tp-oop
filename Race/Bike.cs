namespace Race;

public class Bike : Vehicule
{
    public Bike(double speed, ConsoleColor color) : base(speed, color)
    {
        _acceleration = 0.7;
        _weight = 0.2;
    }

    public override void BrokeDown()
    {
        _broke = 5;
    }

    public override bool Move(uint newPosition, Track track)
    {
        if (_broke != 0)
        {
            _broke--;
            return false;
        }
        position = newPosition;
        if (track is Turn)
        {
            return (Random.Shared.Next(30) < 20);
        }
        else
        {
            return (Random.Shared.Next(80) < 20);
        }
    }

    public override string ToString()
    {
        return "Bike";
    }

    public override void Print()
    {
        Console.ForegroundColor = color;
        Console.Write(ToString());
        Console.ForegroundColor = ConsoleColor.Black;
    }
}