namespace Race;

public abstract class Vehicule
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

    public Vehicule(double speed, ConsoleColor color)
    {
        _speed = speed;
        _broke = 0;
        position = 0;
        this.color = color;
    }

    public Vehicule()
    {
        throw new NotImplementedException();
    }
    
    public double GetWeight()
    {
        return _weight;
    }

    public virtual void BrokeDown()
    {
        _broke = 3;
    }

    public abstract bool Move(uint newPosition, Track track);

    public bool IsBroke()
    {
        return (_broke != 0);
    }
    
    public static bool operator <(Vehicule vehicule1, Vehicule vehicule2)
    {
        return vehicule1.GetWeight() < vehicule2.GetWeight();
        
        switch (vehicule1)
        {
            case Car:
                return (vehicule2 is Truck);
            case Truck:
                return false;
            case Bike:
                return (vehicule2 is not Bike);
        }

        return false;
    }

    public static bool operator >(Vehicule vehicule1, Vehicule vehicule2)
    {
        return vehicule1.GetWeight() > vehicule2.GetWeight();
        
        switch (vehicule1)
        {
            case Car:
                return (vehicule2 is Bike);
            case Truck:
                return (vehicule2 is not Truck);
            case Bike:
                return false;
        }

        return false;
    }

    public abstract void Print();
}