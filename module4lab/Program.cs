using System;
using System.Security;
using System.Threading;

namespace Module4Lab {

    class Program
    {
        static void Main(string[] args){
            //print a welcome message
            Console.WriteLine("Welcome to Rocket Countdown:");
            Console.WriteLine("Get Ready for Liftoff...\n");

            //First countdown using a for loop
            Console.WriteLine("Starting main engine teste...");
            for (int i = 5; i >=1; i--){
                Console.WriteLine($"T-{i} seconds...");
                Thread.Sleep(1000); //pause for one second
            } //end loop
            Console.WriteLine("Main engines tested successfully");

            //Seconds countfown using while loop
            Console.WriteLine("Beginning final countdown!");
            int countdown =10;
            while (countdown > 0){
                Console.WriteLine($"T-{countdown} seconds...");
                Thread.Sleep(1000);
                countdown--;
            } //end while

            //liftoff Sequence
            Console.WriteLine("\n Liftoff! We have liftoff!");

            //altitude reporting using a for loop a different increment
            for (int altitude = 0; altitude <=50; altitude += 10) {
                Console.WriteLine($"Altitude: {altitude} kilometers");
                Thread.Sleep(500);
            }//end for loop

            Console.WriteLine("\n Missions successful! The rocket has reached its target altitude");
        } //end main
    }//end program
}//end namespace