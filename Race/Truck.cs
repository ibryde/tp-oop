namespace Race;

public class Truck : Vehicule
{
    public Truck(double speed, ConsoleColor color) : base(speed, color)
    {
        _acceleration = 0.3;
        _weight = 0.8;
    }

    public override bool Move(uint newPosition, Track track)
    {
        if (_broke != 0)
        {
            _broke--;
            return false;
        }
        position = newPosition;
        return (Random.Shared.Next(100) < 20);
    }

    public override string ToString()
    {
        return "Truck";
    }
    
    public override void Print()
    {
        Console.ForegroundColor = color;
        Console.Write(ToString());
        Console.ForegroundColor = ConsoleColor.Black;
    }
}