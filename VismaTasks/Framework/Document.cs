using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VismaTasks.Framework
{
    
    public static class Document
    {
        //Task number 1
        public static string number;
        public static string maxNumber = "100";
        public static DateTime date;
        public static Row[] row;

        //Task number 3
        public static string RandomString(int stringLength)
        {
            var chars = "0123456789";
            var stringChars = new char[stringLength];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString;
        }

        //For combined tasks
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }

        //Task number 3
        public static DateTime MondayOfCurrentWeek()
        {
            date = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            return date;
        }

        //Task number 3
        public static void EnterDocumentData(int itemQuantity)
        {
            for (int i = 0; i < itemQuantity; i++)
            {
                string text = RandomString(7);
                Thread.Sleep(10);
                Print("Number: " + text);
            }
        }
    }
}
