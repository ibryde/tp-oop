namespace Race;

public abstract class Vehicule
{
    protected double _speed;
    protected double _accelaration;
    protected double _weight;
    protected uint _broke;
    
    public double Speed
    {
        get => _speed;
    }
    public double Accelaration
    {
        get => _accelaration;
    }

    public Vehicule()
    {
        _broke = 0;
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