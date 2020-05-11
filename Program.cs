using System;

namespace Parser_C_
{
    class Program
    {
        static void Main(string[] args)
        {
           
             option = "1";

            switch(option){
                case "1": 
                    Console.WriteLine("Please enter filename");
                    string fileName = Console.ReadLine();
                    Console.WriteLine("The filename will be stored in a local variable");
                   
                case "2":
                    Console.WriteLine("Please enter filename");
                    Console.WriteLine("filName: " + "" + fileName);
                    
              
                case "3":

                int option = 0; 

                while (option < 3){ 
                    option++;
                    Console.WriteLine(option);
                }
                break;
               
            }       

        }
    }
}
