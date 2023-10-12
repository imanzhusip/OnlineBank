using System;
using System.Collections.Generic;
using Tima.BLL;
using Tima.DAL;

namespace Module4
{
    public class Program
    {
        public static ServiceClient service = new ServiceClient();
        static void Main(string[] args)
        {


            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Регистрация");
            Console.WriteLine("2. Авторизация");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Client newClient = new Client();

                Console.WriteLine("Введите иин:");
                newClient.Iin = Console.ReadLine();

                Console.WriteLine("Введите почту:");
                newClient.Email = Console.ReadLine();

                Console.WriteLine("Введите фамилию:");
                newClient.Fname = Console.ReadLine();

                Console.WriteLine("Введите имя:");
                newClient.Sname = Console.ReadLine();

                Console.WriteLine("Введите отчество:");
                newClient.Mname = Console.ReadLine();
                Console.WriteLine("Введите логин:");
                newClient.Login = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                newClient.Password = Console.ReadLine();


                
                bool result = service.Registration(newClient);
                if(result = true)
                {
                    Console.WriteLine("Клиент успешно создался");
                }
                else
                {
                    Console.WriteLine("При создании клиента возникла ошибка, попробуйте позже");
                }

            }
            else if (choice == "2")
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string password = Console.ReadLine();

                
                
                Client client = service.Auth(login, password);

                if(client != null)
                {
                    Console.Clear();
                    Console.Write("ПРиветствую тебя {0}",client.Getshortname);

                }
                else
                {
                    Console.WriteLine("Авторизация не прошла");
                }



            }

           
            Console.ReadKey();
        }
    }

    
}
