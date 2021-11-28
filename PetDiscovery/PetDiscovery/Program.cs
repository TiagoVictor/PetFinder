using PetDiscovery.DAO;
using PetDiscovery.Model;
using System;
using System.Collections.Generic;

namespace PetDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDao cd = new CustomerDao();
            Customer c = new Customer();
            LogedUser lg = new LogedUser();

            AnimalsDao ad = new AnimalsDao();
            Animals a = new Animals();
            List<Animals> lst = new List<Animals>();


            Console.WriteLine("Bem vindo ao sistema");
            Console.WriteLine("Para logar insira seu usuario e senha:");
            Console.WriteLine("Usuario:");
            c.Email = Console.ReadLine();
            Console.WriteLine("Senha:");
            c.Password = Console.ReadLine();

            c = cd.GetCustomer(c.Email, c.Password);

            if (c.Email != null && c.Password != null )
            {
                lg.Email = c.Email;
                lg.Id = c.Id;
                lg.Nome = c.Name;
            }

            do
            {

            }while (lg != null);
        }
    }
}
