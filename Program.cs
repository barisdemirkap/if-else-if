using System;

namespace if_else_if
{
    class Program 
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour ;
            if(time >= 6 && time <= 11)
                Console.WriteLine("Gunaydin!!") ;
            else if(time <= 18)
                Console.WriteLine("Iyi Gunler!!") ;
            else 
                Console.WriteLine("Iyi GECELER!!") ;

            string result = time <=18 ? "Iyi Gunler!!" : "Iyi GECELER!!" ;
            result = time >= 6 && time<11 ? "Gunaydin!!" : time <=18 ? "Iyi Gunler!!" : "Iyi Geceler" ;
            Console.WriteLine(result) ;
            
           
        }

    }
}