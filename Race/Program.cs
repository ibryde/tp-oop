using System.Numerics;

namespace Race
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ------------------------------
            // Why is it red underline?

            int a;
            int b = a + 5;
            
            a = 3;
            b = a + 5;

            return;
            ;
            // --------------------------------
            
            // --------------------------------
            // Is it the same thing here?

            int[] list;
            list[0] = a;


            return;
            ;
            // --------------------------------
            
            // ------------------------------
            // Is it fixed now?

            list = new int[10];
            list[0] = list[1];

            return;
            ;
            // --------------------------------
            
            // ------------------------------
            // Why can't I create a new vehicule?
            
            Bike bike = new Bike();
            Car car = new Car();
            Truck truck = new Truck();
            
            Vehicule vehicule = new Vehicule();

            return;
            ;
            // ------------------------------
        }
    }
}