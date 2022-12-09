namespace Race;

public class Race
{
    private Vehicule[] _racers;
    private Track[] _track;
    public Random rand;

    private ConsoleColor[] ListColors =
    {
        ConsoleColor.Blue,
        ConsoleColor.Magenta,
        ConsoleColor.Red,
        ConsoleColor.DarkYellow,
        ConsoleColor.DarkRed,
        ConsoleColor.Green,
        ConsoleColor.Cyan,
        ConsoleColor.DarkMagenta,
        ConsoleColor.DarkGray,
        ConsoleColor.Yellow,
    };

    public Race(int nb_racers, Random rand)
    {
        _track = new Track[30];
        _racers = new Vehicule[nb_racers];
        this.rand = rand;
        
        for (uint i = 0; i < 10; i++)
        {
            if (rand.Next(10) < 7)
                _track[i] = new Track();
            else
                _track[i] = new Turn();
        }

        for (uint i = 0; i < nb_racers; i++)
        { 
            double speed = rand.NextDouble();
            switch (rand.Next(3))
            {
                case 0:
                    _racers[i] = new Car(speed, ListColors[i%10])

            ;
                    break;
                case 1:
                    _racers[i] = new Bike(speed, ListColors[i%10]);
                    break;
                case 2:
                    _racers[i] = new Truck(speed, ListColors[i%10]);
                    break;
            }
        }
    }

    protected Vehicule[] Max()
    {
        uint max_position = 0;
        uint nb_first = 0;
        
        // First, I check the furthest car
        foreach (Vehicule vehicule in _racers)
        {
            if (vehicule.position > max_position)
            {
                max_position = vehicule.position;
                nb_first = 1;
            }
            else if (vehicule.position == max_position)
            {
                nb_first += 1;
            }
        }

        Vehicule[] furthest = new Vehicule[nb_first];
        uint i = 0;
        foreach (Vehicule vehicule in _racers)
        {
            if (vehicule.position == max_position)
            {
                furthest[i] = vehicule;
                i++;
            }
        }
        
        return furthest;
    }

    private void PrintRacers()
    {
        string separator = "{ ";
        foreach (Vehicule vehicule in _racers)
        {
            Console.Write(separator);
            vehicule.Print();
            separator = ", ";
        }

        Console.WriteLine("}");
}
    
    private void Announcement()
    {
        Vehicule[] first = Max();

        if (first.Length == 1)
        {
            first[0].Print();
            Console.WriteLine(" is first.");
        }
        else
        {
            Console.WriteLine("We have a lot of racers tied!");
        }
    }

    private void Sort()
    {
        for (uint j = 1; j < _racers.Length; j++)
        {
            for (uint i = 0; i < j; i++)
            {
                if (_racers[i] > _racers[j])
                    (_racers[i], _racers[j]) = (_racers[j], _racers[i]);
            }
        }
    }
    
    private void FinalAnnouncement()
    {
        Vehicule winner = Max()[0];

        Console.Write("And the winner is... ");
        winner.Print();
        Console.WriteLine("! Congratulation to all racers");
    }
    
    private bool Next()
    {
        foreach (Vehicule vehicule in _racers)
        {
            uint i = vehicule.position;
            if (_track[i] is Turn)
                i += (uint) vehicule.Acceleration * 10;
            i += (uint) (vehicule.Speed * 10);
            
            if (i >= _track.Length)
            {
                return false;
            }
            
            
            if (vehicule.Move(i, _track[i]))
            {
                vehicule.BrokeDown();
            }
        }
        
        Sort();

        for (uint i = 0; i < _racers.Length; i++)
        {
            if (_racers[i] is Bike || _racers[i].IsBroke())
                continue;
            
            for (uint j = 0; j < _racers.Length; j++)
            {
                if (_racers[j] is Truck || _racers[j].IsBroke())
                    break;
                
                if (_racers[i] > _racers[j])
                {
                    if (rand.Next(10) == 1)
                    {
                        _racers[j].BrokeDown();
                       Console.Write("Oh! Did you see ");
                       _racers[i].Print();
                       Console.Write(" just hit ");
                       _racers[j].Print();
                       Console.WriteLine(". He is now broke down.");
                    }
                }
            }
        }
        
        return true;
    }

    public void Play()
    {
        PrintRacers();
        Console.WriteLine("Wait for input..."); Console.ReadKey();
        Console.Clear();
        
        while (Next())
        {
            Announcement();
            Console.WriteLine("Wait for input..."); Console.ReadKey();
            Console.Clear();
        } 
        
        FinalAnnouncement();
    }
}