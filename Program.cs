using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace LessonGB5
{
    partial class Program
    {


        static void Main()
        {
           Ex1_1();
           Ex1_2();
           //Ex2();

        }
static void Ex2()
         {
            string str = "У Саши собака Пушок. У Даши – кошка Машка. Пушок любит кости, а Машка – мышек.";
            Message.AmountLet(str, 5);
            Console.WriteLine();
            Console.WriteLine(Message.LongLet(str));      
            Console.ReadLine();
        }






        //задание без регулярных выражений
        static void Ex1_1()
        {
            Console.WriteLine("Введите логин");

            string strin = Console.ReadLine();
            CheckLogin(strin);




            if (CheckLogin(strin))
            {
                Console.WriteLine("Отлично! Теперь при помощи регулярных выражений!");
                Ex1_2();
            }

            else
            {
                Console.WriteLine("Неверный логин");
                Ex1_1();
            }
            Console.ReadLine();
        }


        //Метод проверки условий задания.
        static bool CheckLogin(string ss)
        {
            bool found = false;
            for (int i = 0; i < ss.Length; i++)
            {
                char ch = ss[0];


                if (ss.Length > 2
                && ss.Length < 12
                && !Char.IsDigit(ch) && IsLatin(ss[i])
                )
                    found = true;




            }
            return found;

        }
        //Метод для определения латинских букв
        static bool IsLatin(char lat)
        {
            return (lat >= 'A' && lat <= 'Z') || (lat >= 'a' && lat <= 'z');
        }

        //Регулярные выражения
        static bool CheckLoginReg(string ss)
        {

            if (ss.Length >= 2 && ss.Length <= 10)
            {
                if (Regex.IsMatch(ss[0].ToString(), @"\d")) return false;
                return Regex.IsMatch(ss, @"[a-zA-Z]\w{1,9}");
            }
            return false;
        }

        //задание с регулярными выражениями
        static void Ex1_2()
        {
            Console.WriteLine("Введите логин");

            string strin = Console.ReadLine();
            CheckLogin(strin);




            if (CheckLoginReg(strin))
            {
                Console.WriteLine("Отлично!");

            }

            else
            {
                Console.WriteLine("Неверный логин");
                Ex1_2();
            }
            Console.ReadLine();

        }


    }
}