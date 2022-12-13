using System;
using System.Collections.Generic;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer() { Name = "Juancho", RegistrationDate = DateTime.Now},
                new Customer() { Name = "Miguel", RegistrationDate = DateTime.Now},
                new Customer() { Name = "Roberto", RegistrationDate = DateTime.Now},
                new Customer() { Name = "Jason", RegistrationDate = DateTime.Now},
                new Customer() { Name = "Maria", RegistrationDate = DateTime.Now},
                new Customer() { Name = "Daniela", RegistrationDate = DateTime.Now},
                new Customer() { Name = "Ramirez", RegistrationDate = DateTime.Now},
                new Customer() { Name = "Jose", RegistrationDate = DateTime.Now},
                new Customer() { Name = "Alberto", RegistrationDate = DateTime.Now},
                new Customer() { Name = "Fernando", RegistrationDate = DateTime.Now}
            };

            Console.WriteLine("Bucle foreach");
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customers.IndexOf(customer)+1}.- Name: {customer.Name} Registration Date: {customer.RegistrationDate}");
            }

            Console.WriteLine("\nBucle For");
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"{i+1}.- Name: {customers[i].Name} Registration Date: {customers[i].RegistrationDate}");
            }

            Console.WriteLine("\nBucle while");
            var aux = 0;
            while (aux < customers.Count)
            {
                Console.WriteLine($"{aux+1}.- Name: {customers[aux].Name} Registration Date: {customers[aux].RegistrationDate}");
                aux++;
            }

            Console.WriteLine("\nBucle do while");
            aux = 0;
            do
            {
                Console.WriteLine($"{aux+1}.- Name: {customers[aux].Name} Registration Date: {customers[aux].RegistrationDate}");
                aux++;
            } while (aux < customers.Count);
        }
    }
}
