using System;

class MainClass {
  public static void Main (string[] args) {


    int counter = 0;
    int totalSpeed = 0;

    Console.WriteLine("Number of car # ");
    int numOfCars = Convert.ToInt32(Console.ReadLine());

    while(counter < numOfCars)
    {

    Console.WriteLine ("Enter distance covered by this car ");
    double distance = Convert.ToDouble(Console.ReadLine());
   
    Console.WriteLine("Enter time taken by this car ");
    double time = Convert.ToDouble(Console.ReadLine());

    double speed = distance / time;
    Console.WriteLine("The speed of the car is " + speed + " miles per hour.");

    totalSpeed = totalSpeed + (int)speed;
    counter++;
    }

    int totalAverage = totalSpeed / numOfCars;

    Console.WriteLine("The average speed of the cars is " + totalAverage + " miles per hour.");

  }
}