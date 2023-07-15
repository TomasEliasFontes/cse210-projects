using System;

class Program
{
    static void Main(string[] args)
    {
        // Address:
        Address address1 = new Address("Calle Sarmiento 1023, 9° B°", "Belgrano", "Buenos Aires", "Argentina");
        Address address2 = new Address("387 Washington Street, Apartment 20", "Washington", "DC", "USA");
        Address address3 = new Address("San Nicolas 266", "Flamengo", "Rio de janeiro", "Brasil");

        // Customers: 
        Customer customer1 = new Customer("David Varisa", address1);
        Customer customer2 = new Customer("Jesse Montiel", address2);
        Customer customer3 = new Customer("Raimundo Jaime", address3);

        //Products:
        Product product1 = new Product("HeadPhone","74739",39.99,1);
        Product product2 = new Product("PlayStation","97483",99.99,1);
        Product product3 = new Product("T-Shirt","63274",10.99,3);
        Product product4 = new Product("Spray","12345",10.99,2);
        Product product5 = new Product("Glasses","25463",19.99,5);
        Product product6 = new Product("Paper A4","98765",19.99,2);
        Product product7 = new Product("Pillow","512315",20,3);
        Product product8 = new Product("Bread","332335",14.99,1);
        Product product9 = new Product("Jam","343355",19.99,2);

        //List for products;
        List<Product> products1 = new List<Product>()
        {
            product1,
            product2,
            product3
        };

        List<Product> products2 = new List<Product>()
        {
            product4,
            product5,
            product6
        };

        List<Product> products3 = new List<Product>()
        {
            product7,
            product8,
            product9
        };

        //Orders for the customer with their products and cost
        Order order1 = new Order(products1,customer1);
        Order order2 = new Order(products2,customer2);
        Order order3 = new Order(products3,customer3);

        //List the orders to print one by one
        List<Order> orders = new List<Order>(){
            order1,
            order2,
            order3
        };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.ShippingLabel() + "\n");
            Console.WriteLine(order.PackingLabel() + "\n");
            Console.WriteLine("Total Cost:" + "\n" + 
            "   " + order.TotalCost());
            Console.WriteLine(new string('-', 100));
        }

    }
}