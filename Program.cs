using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAnketa
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userSurname;
            float userHeight;
            float userAge;
            string userСitiesResidence;
            string userProfession;

            Console.Write("Как вас зовут?:");
            userName = Console.ReadLine();

            Console.Write("Какая ваша фамилия ?:");
            userSurname = Console.ReadLine();

            Console.Write("Сколько  вам полных лет?:");
            userAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Какой ваш рост?:");
            userHeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("В каком городе вы проживаете?:");
            userСitiesResidence = Console.ReadLine();

            Console.Write("Какая ваша профессия?:");
            userProfession = Console.ReadLine();


            Console.WriteLine($"Ваше полное имя {userName} {userSurname}, ваш возвраст  {userAge} год" +
                $" и ваш рост {userHeight}, город в котором вы проживаете {userСitiesResidence} и ваша профессия {userProfession}");
        }
    }
}
