using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace LessonGB5
{
   
    static class Message
    {
        //Вывести только те слова сообщения,  которые содержат не более n букв.
        public static void AmountLet(string str, int n)
        {
            string[] array = str.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= n ) Console.Write(array[i]);
            }
        }      

        //Найти самое длинное слово сообщения.
        public static string LongLet(string str)
        {
            string[] array = str.Split(' ');
            str = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > str.Length) str = array[i];
            }
            return str;
        }

       
       
    }
}
   
    
