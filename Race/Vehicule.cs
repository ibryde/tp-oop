namespace Race;

public abstract class Vehicule
{
    protected double _speed;
    protected double _accelaration;
    protected double _weight;
    protected uint _broke;
    public uint position;
    
    public double Speed
    {
        get => _speed;
    }
    public double Accelaration
    {
        get => _accelaration;
    }

    public Vehicule(double speed)
    {
        _broke = 0;
        position = 0;
    }

    public Vehicule()
    {
        throw new NotImplementedException();
    }
    
    public double GetWeight()
    {
        throw new NotImplementedException();
    }

    public virtual int BrokeDown()
    {
        throw new NotImplementedException();
    }

}