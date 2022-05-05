using System;
using System.Linq;

namespace MinimumCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A group of friends is going on holiday together.
            //They have come to a meeting point ( the start of the journey) using N cars.
            //There are P[k] people and S[k] seats in the K-th car for K in range [0..N-1].
            //Some of the seats in the cars may be free, so it is possible for some of
            //the friends to change the car they are in. The friends have decided that,
            //in order to be ecological, they will leave some cars parked at the
            //meeting point and travel with as few cars as possible.

            int[] people = new int[] { 4, 4, 2, 4 };
            int[] cars = new int[] { 5, 5, 2, 5 };
            Array.Sort(cars);
            Array.Reverse(cars);
            int totalPeople = people.Sum();
            int aux = 0;
            while (totalPeople > 0)
            {
                totalPeople -= cars[aux];
                aux++;
            }
            Console.WriteLine("Minimum cars: " + aux);
            Console.ReadKey();
        }
    }
}
