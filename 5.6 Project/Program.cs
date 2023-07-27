using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5._6_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = User();
            GetUser(user);
            Console.ReadKey();
        }
            static (string , string , byte, string[] , string[]) User()
        {
            byte Age = 0;
            byte PetsCount = 0;
            byte Favcolors = 0;
            Console.WriteLine("Введите имя:");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            CheckNum(ref Age);
            Console.WriteLine("Наличие питомцев (Введите true или false:");
            bool IsPets = Convert.ToBoolean(Console.ReadLine());

            string[] var = new string[PetsCount];
            if (IsPets)
            {
               Console.WriteLine("Введите количество питомцев:");
               CheckNum(ref PetsCount);
               Console.WriteLine("Введите клички питомцев:");
               var = PetsNames(PetsCount);
            }
            Console.WriteLine("Введите количество любимых цветов:");
            CheckNum(ref Favcolors);
            string[] colors = new string[Favcolors];
            colors = favcolors(Favcolors);
            var result = (Name, Surname, Age, var, colors);
            return result;
        }

        static string[] PetsNames (byte PetsCount)
        {
            string[] petsnames = new string [PetsCount];
            for(int i = 0; i < PetsCount; i++)
            {
                Console.WriteLine($"Кличка питомца {i + 1}:");
                petsnames[i] = Console.ReadLine();
            }
            return petsnames;
        }
        static string[] favcolors(byte Favcolors)
        {
            string[] favcolors = new string [Favcolors];
            for (int i = 0; i < Favcolors; i++)
            {
                Console.WriteLine($"Любимый цвет {i + 1}:");
                favcolors[i] = Console.ReadLine();
            }
            return favcolors;
        }
        static void CheckNum(ref byte checkvar, bool status = false)
        {
            while (!status || checkvar <= 0)
            {
                status = byte.TryParse(Console.ReadLine(), out checkvar);
            }
        }

        static void GetUser((string , string , byte, string[], string[]) User)
        {
            Console.WriteLine($"Имя:{User.Item1}");
            Console.WriteLine($"Фамилия:{User.Item2}");
            Console.WriteLine($"Возраст:{User.Item3}");
            for(int i = 0; i < User.Item4.Length; i++)
            {
                Console.WriteLine($"Кличка питомца {i + 1} : {User.Item4[i]}");
            }
            for (int i = 0; i < User.Item5.Length; i++)
            {
                Console.WriteLine($"Любимый цвет {i + 1} : {User.Item5[i]}");
            }
        }
    }
}
