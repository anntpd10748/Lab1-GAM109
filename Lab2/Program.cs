// See https://aka.ms/new-console-template for more information

using System;

public class Maps
{
    public string ID;
    public string Name;
    public static string InGame = "lien minh huyen thoai";

    public Maps(string id, string name)
    {
        this.ID = id;
        this.Name = name;
    }
       
    public string ShowData()
    {
        return "ID: " + ID + "|Name: " + Name + "|inGame: " + InGame;
    }
}
public class Program
{
    public static int Main(string[] args)
    {
        Maps maps = new Maps("132456","lienminh");
        Console.WriteLine(maps.ShowData());
        return 0;
    }
}

