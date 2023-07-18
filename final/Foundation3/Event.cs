using System;
using System.Collections.Generic;


public class Event
{

    private string _title, _description, _date, _time,_type;
    Address _address;

    public Event(string type, string title,string description,string date,string time,Address address) 
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // This is how is gonna we displey the title, description, date, time and the address for the user in the system(Program.cs)
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }



    public string GetAddress()
    {
        string _addresses = _address.GetFulldAddress();
        return _addresses;
    }

  

    // Show the standard details of that event
    public void StandardDetails()
    {        
        Console.WriteLine($"{_type}");
        Console.WriteLine($"Title : {_title}");
        Console.WriteLine($"Description : {_description}");
        Console.WriteLine($"Date : {_date}");
        Console.WriteLine($"Time : {_time}");
        Console.WriteLine($"Address : {GetAddress()}");  
     
    }  

    // Show the all details of that event
    public void FullDetails()
    {
        Console.WriteLine($"{_type}");
        Console.WriteLine($"Title : {_title}");
        Console.WriteLine($"Description : {_description}");
        Console.WriteLine($"Date : {_date}");
        Console.WriteLine($"Time : {_time}");
        Console.WriteLine($"Address : {GetAddress()}");

    }

    // Show us the short description event
    public void ShortDescription()
    {
        Console.WriteLine($"{_type}");
        Console.WriteLine($"Title : {_title}");        
        Console.WriteLine($"Date : {_date}");       
    }

 
}