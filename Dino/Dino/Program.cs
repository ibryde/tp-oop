// See https://aka.ms/new-console-template for more information

using Dino;

Game g = new Game(15, 60);

Random r = new Random();

while (true)
{
    g.Print();
    g.Swipe();
    g.Next(r);
}