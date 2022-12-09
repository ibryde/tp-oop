namespace Race;

public abstract class Vehicle
{
    protected double _speed;
    protected double _acceleration;
    protected double _weight;
    protected uint _broke;
    public uint position;
    public ConsoleColor color;
    
    public double Speed
    {
        get => _speed;
    }
    public double Acceleration
    {
        get => _acceleration;
    }

    /// <summary>
    /// Constructor for a vehicle.
    /// Set the value as follows:
    /// _speed and color as the argument of the function
    /// _bloke and position as 0
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="color"></param>
    public Vehicle(double speed, ConsoleColor color)
    {
        _speed = speed;
        _broke = 0;
        position = 0;
        this.color = color;
    }

    /// <summary>
    /// Do not edit this function.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public Vehicle()
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Getter for Weight
    /// </summary>
    /// <returns></returns>
    public double GetWeight()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// The vehicle has broken down! No way.
    /// Set the _broke value at 3.
    /// </summary>
    public virtual void BrokeDown()
    {
        throw new NotImplementedException();
    }
    
    public abstract bool Move(uint newPosition, Track track, int luck);

    /// <summary>
    /// Is your vehicle broken down?
    /// Check if the _broke value is different from 0.
    /// </summary>
    /// <returns></returns>
    public bool IsBroke()
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Check if the first vehicle is lighter than the second one.
    /// </summary>
    /// <param name="vehicle1"></param>
    /// <param name="vehicle2"></param>
    /// <returns></returns>
    public static bool operator <(Vehicle vehicle1, Vehicle vehicle2)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Check if the first vehicle is heavier than the second one.
    /// </summary>
    /// <param name="vehicle1"></param>
    /// <param name="vehicle2"></param>
    /// <returns></returns>
    public static bool operator >(Vehicle vehicle1, Vehicle vehicle2)
    {
        throw new NotImplementedException();
    }

    public abstract void Print();
}