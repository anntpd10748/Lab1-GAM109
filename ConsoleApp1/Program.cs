using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserData.ShowData();
            Console.ReadLine();
        }
    }
    public static class UserData
    {
        public static string Id;
        public static string UserName;
        public static float Gold;
        public static int Point;

        static UserData()
        {
            Id = "123";
            UserName = "abc";
            Gold = 12.3f;
            Point = 100;
        }
        public static void ShowData()
        {
            Console.WriteLine("Id: " + UserData.Id);
            Console.WriteLine("UserName: " + UserData.UserName);
            Console.WriteLine("Gold: " + UserData.Gold);
            Console.WriteLine("Point: " + UserData.Point);
        }
    }
    
}
