using System;
using CsharpSocialNetworkManager.Models;

namespace CsharpSocialNetworkManager
{
    class program
    {
        static void Main(string[] args)
        {
            //AppManager app = new AppManager();
            var app = new AppManager();

            Console.WriteLine($"Bienvenido a {app.AppTitle}");
            Console.WriteLine("Porfavor ingrese su nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Porfavor ingrese su correo");
            string email = Console.ReadLine();
            Console.WriteLine("Porfavor ingrese su edad");
            short age = short.Parse(Console.ReadLine());
           

            var user = new User();
            user.Name = name;
            user.Email = email;
            user.Age = age;

            if (user.IsValid(true))
            {
                Console.WriteLine("sus datos son ");
                Console.WriteLine($"Nombre: {user.Name}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Edad: {user.Age}");
                Console.WriteLine($"Esta activo: {user.IsActived}");
                Console.WriteLine($"Fecha de creacion: {user.DateCreated}");
            }
            else
            {
                Console.WriteLine("Los datos del usuario no son validos");
                
            }


           




        }
    }
}