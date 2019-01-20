using System;

namespace Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            //a program that calculates how much time it will take to fill a pool with water
            //gives pool a volume of water(v ) in cubic metres and 3 debit pipes:D1,D2,D3(metres  cubed per hour)
            //input consists of natural numbers (1-101)
            //print out an appropriate message if the input has an outgoing pipe
            Console.WriteLine("welcome to the program");
            Console.WriteLine("input the volume of the pool in metres cubic");
            int volume=Convert.ToInt32(Console.ReadLine());
            if(volume<1 || volume>10000)
            {
             Console.WriteLine("you have entered an invalid entry try again");
            }
            else 
            {
                Console.WriteLine("Enter the volume of the first pipe D1");
                int D1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the volume of the second pipe D2");
                int D2=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the volume of the third pipe D3");
                int D3=Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("The total volume of the pipes is ")
                int sum=D1+D2+D3;
                Console.WriteLine( $"the total volume of the pipes is {sum} ");
                 int time=volume/sum;
                 Console.WriteLine($"The total time that the pool can get filled is {time} hours");

            }
            

        }
    }
}
