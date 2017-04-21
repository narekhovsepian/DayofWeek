using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            DayofWeek day1 = DayofWeek.Friday;
            DayofWeek day2 = DayofWeek.Monday;
            DayofWeek day3 = DayofWeek.Thursday;
            Console.WriteLine(day1 + " " + (int)day1);
            int a = 5;
            Console.WriteLine((DayofWeek)a);
            Print(day1);
            PrintAllEnumValues();

        }
        static void Print(DayofWeek day) {
            switch (day) {
                case DayofWeek.Friday:
                    Console.WriteLine("yaahoo");
                    break;
                default:
                    Console.WriteLine("noo");
                    break;
                           
               
            }
          
                }
        static void PrintAllEnumValues() {
            String[] enumNames = Enum.GetNames(typeof(DayofWeek));
                for (int i = 0; i < enumNames.Length; i++) {
                DayofWeek day = (DayofWeek)Enum.Parse(typeof(DayofWeek), enumNames[i]);
                Console.WriteLine(enumNames[i]+" "+day+(int)day);
               
             
            }
                }
    }
}
