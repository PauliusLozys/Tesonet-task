using System;

namespace Tesonet_task
{
    class Program
    {
        // Three friends want to go to the destination which is 20km away. The walking speed is 5km per hour. 
        // One of them has a bike and can drive it at speed of 20 km/h and can take one friend with him. 
        // What is the best approach to get to their destination as fast as possible?

        // Write an application that could calculate this given different speeds and distances.
        // Improve it to calculate given a different number of friends.
        static void Main(string[] args)
        {
            Console.Write("Input destination range: ");
            var line = Console.ReadLine();
            double destination = int.Parse(line);

            Console.Write("Input bike speed range: ");
            line = Console.ReadLine();
            double bikeSpeed = int.Parse(line);

            Console.Write("Input walking speed range: ");
            line = Console.ReadLine();
            double walkingSpeed = int.Parse(line);

            // time taken to get to the other friend
            // driven disntace = p
            // T = p / bikeSpeed

            // time walked while getting bike was getting back
            // same distance was walked by the person that was
            // let go off the bike
            // walked disntace = q
            // T = q / walkingSpeed 
            


            // T = q / walkingSpeed = p / bikeSpeed =>p = bikeSpeed / walkingSpeed * q => middleMultiplayer * q
            double middleMultiplayer = bikeSpeed / walkingSpeed;

            // (middleMultiplayer * q + q + r) / bikeSpeed = r / walkingSpeed => lastPartMultiplayer * q
            double lastPartMultiplayer = (middleMultiplayer * walkingSpeed + walkingSpeed) / (bikeSpeed - walkingSpeed);

            // lastPartMultiplayer * q + q + middleMultiplayer * q + q + lastPartMultiplayer * q
            double travelDisntace = lastPartMultiplayer * 2 + middleMultiplayer + 2;
            // q = distance / travelDisntace
            double disntanceX = destination / travelDisntace;

            //  T = T(drop off a friend) + T(friends walked disntace) 
            // T(drop off a friend) = lastPartMultiplayer * q + q + middleMultiplayer * q
            double xx = lastPartMultiplayer * disntanceX + disntanceX + middleMultiplayer * disntanceX;
            // T(friends walked disntace)  = q + middleMultiplayer * q
            double yy = disntanceX + lastPartMultiplayer * disntanceX;
            double timeTaken = xx / bikeSpeed + yy / walkingSpeed; 

            Console.WriteLine($"{Math.Round(timeTaken, 2)} hours to reach the destination");
        }
    }
}
