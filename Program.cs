using System;

namespace StudentDocumentsManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SDMS!");

            Console.Write("Username: ");
            string UsrName = Console.ReadLine();
            Console.Write("Password: "); 
            string PsWord = Console.ReadLine();

            

            if (UsrName == "admin" & PsWord == "admin")
            {
                Console.WriteLine("||||You are logged in!||||");


                Console.WriteLine("\n");
                string tool1 = "Admission Requirements";
                string tool2 = "Clearance";
                string tool3 = "TOR";

                Console.WriteLine("Tools: " + "\n" + tool1 + "\n" + tool2 + "\n" + tool3);

                Console.WriteLine("\n");
                Console.WriteLine("Enter: ");
                string tools = Console.ReadLine();
                
                if (tools == (tool1))
                {  

                    string studname1 = ("Murro, Bryll Kenryl T.");
                    Console.WriteLine("\n");

                    Console.WriteLine("Enter Student Name: ");
                    string studname = Console.ReadLine();
                    
                    if (studname == (studname1))
                    {
                        Console.WriteLine("Documents completed!");
                    }
                    else
                        Console.WriteLine("Invalid!");

                }


                else if (tools == (tool2))
                {
                    Console.WriteLine("none");

                }
                else if (tools == (tool3))
                {
                    Console.WriteLine("none");

                }
                else
                {
                    Console.WriteLine("INVALID INPUT!");
                }

            }
            else
                Console.WriteLine("INVALID INPUT!");


            Console.ReadLine();

        }

        
    }
}
