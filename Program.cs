using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            int Susansage = 0;
            Console.Write("Hello Susan, welcome to Emelda's Club. How old are you?: ");
            Susansage = int.Parse(Console.ReadLine());

            if(Susansage >= 18) 
            {
                Console.WriteLine("You are old enough to drink here!");
            }
            
            else
            {
                Console.WriteLine("You are too young to drink, please leave.");
            }
            Console.WriteLine();


            int Christianasage = 0;
            Console.Write("Hello Christiana, welcome to Emelda's Club. How old are you?: ");
            Christianasage = int.Parse(Console.ReadLine());
            
            if(Christianasage >= 18) 
            {
                Console.WriteLine("You are old enough to drink here!");
            }
            
            else
            {
                Console.WriteLine("You are too young to drink, please leave.");
            }
            Console.WriteLine();        
            

            int Jaelsage = 0;
            Console.Write("Hello Jael, welcome to Emelda's Club. How old are you?: ");
            Jaelsage = int.Parse(Console.ReadLine());
            
            if(Jaelsage >= 18) 
            {
                Console.WriteLine("You are old enough to drink here!");
            }
            
            else
            {
                Console.WriteLine("You are too young to drink, please leave.");
            }
            Console.WriteLine();


        }
    }
}







