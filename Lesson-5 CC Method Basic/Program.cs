using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_CC_Method_Basic
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                string txt = Console.ReadLine();
                PrintString(txt);
            }
            int[] myArr = new int[3] { 4, 8, 12 };
            GetArr(myArr);

            int age = GetMyAge();//13
            Console.WriteLine(age);

            string firstName = GetMyFirstName();
            Console.WriteLine(firstName);

            string lastName = GetMyLastName();

            long phoneNumber = 847351982371;//GetMyPhoneNumber();
            string fullName = GetFullName("Yossi", "Cohen");
            Console.WriteLine(fullName);

            //string details = PrintDetails(firstName + lastName, age, phoneNumber);
            //Console.WriteLine(details);

            //מקבל ערך מהמשתמש ושולח אותו כארגומנט
            int age2 = int.Parse(Console.ReadLine());

            PrintDetails(fullName, age2);
            string allDetails = GetAllDetails();
            Console.WriteLine(allDetails);
        }

        public static void PrintString(string myText)
        {
            Console.WriteLine(myText);
        }
        public static void GetArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                PrintInt(arr[i]);
            }
        }

        public static void PrintInt(int number)
        {
            Console.WriteLine(number);
        }
        //לא מחזירה ולא מקבלת ערכים
        public static void PrintDateDetails()
        {
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
        }

        //לא מקבלת ערכים ומחזירה מספר
        public static int GetMyAge()
        {
            return 13;
        }

        //לא מקבלת ערכים ומחזירה טקסט
        public static string GetMyFirstName()
        {
            return "Meir";
        }

        //לא מקבלת ערכים ומחזירה טקסט
        public static string GetMyLastName()
        {
            return "Sadon";
        }

        //מקבלת 2 ארגומנטים ומחזירה טקסט
        public static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        public static string PrintDetails(string shuki, int age)
        {
            //Console.WriteLine(shuki + " " + age);
            return shuki + " " + age;
        }
    
        public static string GetAllDetails()
        {
            string firstName = GetMyFirstName();
            string lastName = GetMyLastName();
            int age = GetMyAge();
            long phone = 1231241231;
            long id = 23525234242;

            return id + " " + firstName + " " + lastName + " " + age + " " + phone;
        }
    }
}
