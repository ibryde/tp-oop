namespace Dino;
using System.Threading;



public class Game
{
    public int[,] Board;
    private int _floor;
    private int hole;
    private int _HoleCooldown;
    private int _LevelCooldown;
    private int level;

    public Game(int height, int width)
    {
        Board = new int[height, width];
        _floor = height / 5;
        _HoleCooldown = width + width/2;
        _LevelCooldown = width + width/2;
        level = 0;
        hole = 0;
        for (int i = 0; i < _floor; i++)
            for (int j = 0; j < Board.GetLength(1); j++)
                Board[Board.GetLength(0) - i - 1, j] = 1;
    }

    public void Print()
    {
        Console.SetCursorPosition(0,0);
        if (_HoleCooldown > 0)
            Console.Write("Hole_cooldown  ");
        if (_LevelCooldown > 0)
            Console.Write("Level_cooldown  ");
        Console.Write("                      ");
        Console.WriteLine();
        for (int i = 0; i < Board.GetLength(0); i++)
        {
            for (int j = 0; j < Board.GetLength(1); j++)
            {
                switch (Board[i, j])
                {
                    case 0:
                        break;
                    case 1: // floor
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case 2: // block
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        break;
                    default:
                        break;
                }

                Console.Write(' ');
                Console.BackgroundColor = default;
            }

            Console.WriteLine();
        }
    }

    public void Swipe()
    {
        for (int i = 0; i < Board.GetLength(0); i++)
        {
            for (int j = 1; j < Board.GetLength(1); j++)
            {
                Board[i, j - 1] = Board[i, j];
            }
        }
    }

    public void Next(Random r)
    {
        
        for (int i = 0; i < Board.GetLength(0); i++)
        {
            if (i > Board.GetLength(0) - 1 - (_floor + level))
            {
                Board[i, Board.GetLength(1) - 1] = hole ==  0? 1:0;
            }
            else
                Board[i, Board.GetLength(1) - 1] = 0;
        }

        // hole part
        
        if (hole > 0)
            hole--;
        if (_HoleCooldown > 0)
            _HoleCooldown--;
        if (_HoleCooldown == 0 && r.Next(30) == 2)
        {
            hole = 5;
            _HoleCooldown = 15;
        }
        
        // level

        if (_LevelCooldown == 0)
        {
            int x = r.Next(60);
            if (x == 3 && level != 0)
            {
                level--;
                _LevelCooldown = 40;
            }
            if (x == 6 && level != 4)
            {
                level++;
                _LevelCooldown = 40;
            }
        }
        else
        {
            _LevelCooldown--;
        }
    }

    public void Play()
    {
        Random r = new Random();
    }
}