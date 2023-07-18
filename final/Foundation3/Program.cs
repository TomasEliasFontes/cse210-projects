using System;

class Program
{
    static void Main(string[] args)
    {
        // Lecture event  
        Address address = new Address( "234 Via ","Buenos aires", "BS AS", "Argentina");
        Lecture lecture = new Lecture("LECTURE","Science", "External function", "2023-07-17", "18:00", address, "Einsten Fontes", 30 );

            Console.WriteLine(new string('V',50) + "\n");
            Console.WriteLine("Standars Detail"+ "\n");
            lecture.StandardDetails();
            Console.WriteLine();
            Console.WriteLine(new string('_',100) + "\n");
            Console.WriteLine("Full Details"+ "\n");
            lecture.FullDetails();
            Console.WriteLine();
            Console.WriteLine(new string('_',100) + "\n");
            Console.WriteLine("Short Decription"+ "\n");
            lecture.ShortDescription();
            Console.WriteLine();

        // Reception event
        Address address1 = new Address( "111 Great St", "New York", "NY", "USA");
        Reception reception = new Reception( "RECEPTION","Event Reception", "Room of Events", "2023-07-17", "16:00", address1, "roomevents@gmail.com" );


            Console.WriteLine(new string('V',0) + "\n");
            Console.WriteLine("Standars Detail:"+ "\n");
            reception.StandardDetails();
            Console.WriteLine();
            Console.WriteLine(new string('_',100) + "\n");
            Console.WriteLine("Full Details:"+ "\n");
            reception.FullDetails();
            Console.WriteLine();
            Console.WriteLine(new string('_',100) + "\n");
            Console.WriteLine("Short Decription:"+ "\n");
            reception.ShortDescription();
            Console.WriteLine();

        // OutdoorGathering event
        Address address2 = new Address( "Villa 32, 345 street", "Santiago chile", "Chile", "Chile");
        OutdoorGathering outdoorGathering = new OutdoorGathering( "OUTDOOR","Run Race", "Grand Prix", "2023-04-02", "10:00", address2, "The temperature ranged from 15 C° to a 22.8 C°" );
            
            Console.WriteLine(new string('V',50) + "\n");
            Console.WriteLine("Standars Detail:"+ "\n");
            outdoorGathering.StandardDetails();
            Console.WriteLine();
            Console.WriteLine(new string('_',100) + "\n");
            Console.WriteLine("Full Details:"+ "\n");
            outdoorGathering.FullDetails();
            Console.WriteLine();
            Console.WriteLine(new string('_',100) + "\n");
            Console.WriteLine("Short Decription:" + "\n");
            outdoorGathering.ShortDescription();
            Console.WriteLine();
        }
    
}