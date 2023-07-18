using System;

class Program
{
    static void Main(string[] args)
    {
        // Lecture event  
        Address address = new Address( "123 Main St", "Saltlake", "UT", "USA");
        Lecture lecture = new Lecture("lecture","Math", "Trigonomerical function", "2023-04-02", "14:59", address, "Howard Hunter", 20 );

            Console.WriteLine(new string('V',50) + "\n");
            Console.WriteLine("Standars Detail");
            lecture.StandardDetails();
            Console.WriteLine();
            Console.WriteLine(new string('_',100) + "\n");
            Console.WriteLine("Full Details");
            lecture.FullDetails();
            Console.WriteLine();
            Console.WriteLine(new string('_',100) + "\n");
            Console.WriteLine("Short Decription");
            lecture.ShortDescription();
            Console.WriteLine();

        // Reception event
        Address address1 = new Address( "123 Main St", "Saltlake", "UT", "USA");
        Reception reception = new Reception( "reception","Wedding Reception", "Temple Wedding", "2023-04-02", "14:59", address1, "wedding@weddingmail.com" );


            Console.WriteLine(new string('V',0) + "\n");
            Console.WriteLine("Standars Detail");
            reception.StandardDetails();
            Console.WriteLine();
            Console.WriteLine(new string('_',100) + "\n");
            Console.WriteLine("Full Details");
            reception.FullDetails();
            Console.WriteLine();
            Console.WriteLine(new string('_',100) + "\n");
            Console.WriteLine("Short Decription");
            reception.ShortDescription();
            Console.WriteLine();

        // OutdoorGathering event
        Address address2 = new Address( "123 Main St", "Saltlake", "UT", "USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering( "outdoor","Marathon", "Utah Marathon Festival", "2023-04-02", "14:59", address2, "The temperature ranged from a low of 49F(9.4C) to a high of 73F(22.8C)" );
            
            Console.WriteLine(new string('V',50) + "\n");
            Console.WriteLine("Standars Detail");
            outdoorGathering.StandardDetails();
            Console.WriteLine();
            Console.WriteLine(new string('_',100) + "\n");
            Console.WriteLine("Full Details");
            outdoorGathering.FullDetails();
            Console.WriteLine();
            Console.WriteLine(new string('_',100) + "\n");
            Console.WriteLine("Short Decription");
            outdoorGathering.ShortDescription();
            Console.WriteLine();
        }
    
}