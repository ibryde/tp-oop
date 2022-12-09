namespace Race;

public class Car : Vehicule
{
    public Car(double speed, ConsoleColor color) : base(speed, color)
    {
        _acceleration = 0.5;
        _weight = 0.5;
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
            return (Random.Shared.Next(50) < 20);
        }
        else
        {
            return (Random.Shared.Next(100) < 20);
        }
    }

    public override string ToString()
    {
        return "Car";
    }
    
    public override void Print()
    {
        Console.ForegroundColor = color;
        Console.Write(ToString());
        Console.ForegroundColor = ConsoleColor.Black;
    }
}