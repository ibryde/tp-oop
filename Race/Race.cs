namespace Race;

public class Race
{
    private Vehicle[] _racers;
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

    /// <summary>
    /// This is the constructor for the Race object.
    /// It should initialize the race as follows.
    /// Create nb_racers of vehicle FIRST.
    /// To know whether a vehicle is a Car, a Bike or a Truck.
    /// Use rand.Next(3), if the value is equal to 0, create a car,
    /// if it is equal to 1, create a Bike, a Truck otherwise.
    /// You should for every vehicle compute its speed.
    /// To do so: use rand.NextDouble();
    ///
    /// Then! You should create your track.
    /// Create an array of 30 track.
    /// To know whether a track is a track or a turn.
    /// Compute rand.Next(10), if the value is under 7 (excluded) then its a normal track.
    /// Else its a Turn.
    /// </summary>
    /// <param name="nb_racers"></param>
    /// <param name="rand"></param>
    public Race(int nb_racers, Random rand)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Return a list of the car in first places. The length of the list should be set accordingly.
    /// </summary>
    /// <returns></returns>
    protected Vehicle[] Max()
    {
        throw new NotImplementedException();
    }

    private void PrintRacers()
    {
        string separator = "{ ";
        foreach (Vehicle vehicle in _racers)
        {
            Console.Write(separator);
            vehicle.Print();
            separator = ", ";
        }

        Console.WriteLine("}");
}
    
    private void Announcement()
    {
        Vehicle[] first = Max();

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
        Vehicle winner = Max()[0];

        Console.Write("And the winner is... ");
        winner.Print();
        Console.WriteLine("! Congratulation to all racers");
    }

    private void Crash(Vehicle vehicle1, Vehicle vehicle2)
    {
        vehicle2.BrokeDown();
       Console.Write("Oh! Did you see ");
       vehicle1.Print();
       Console.Write(" just hit ");
       vehicle2.Print();
       Console.WriteLine(". He is now broke down.");
        
    }
    
    /// <summary>
    /// For each vehicle, move it on the track.
    /// To do so, add to the position of the vehicle, (10 * its speed)
    /// Add an extra (10 * its acceleration) if it is on a turn.
    /// If the newposition of the car is equal or higher than the track length, the first car to get there won.
    /// Else, use the Move() method (with luck = rand.Next(100)).
    /// If Move() returns true, then the vehicle should broke down.
    ///
    ///
    /// BONUS:
    /// When every vehicle has moved check if some vehicle have the same position.
    /// If they do, check their type.
    /// If one of them is a Truck and the other one is a Bike or a Car,
    ///     and if (rand.Next(10) == 1) call crash(truck, bike or car).
    /// If one of them is a Car and the other one is a Bike,
    ///     and if (rand.Next(10) == 1) call crash(car, bike)
    ///
    /// This function should return false if one of the Vehicle won the race. True otherwise.
    /// </summary>
    /// <returns></returns>
    private bool Next()
    {
        throw new NotImplementedException();
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