using System;
using System.Collections.Generic;


public class Customer
    {
        // This are the name that are called in private 
        // in this program so as not to confuse with other variables
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }


        //This funcion it call the other funcion in Address to use the country in Order
        public string GetDirection()
        {
            string country = _address.GetCountry();
            return country;
        }
 
        public string GetName()
        { 
            return _name;
        }

        public string GetAddress()
        {
            string address = _address.GetFulldAddress();
            return address;        
        }
    }