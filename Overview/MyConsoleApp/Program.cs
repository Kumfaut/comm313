// See https://aka.ms/new-console-template for more information

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello World!");

        string response;
        Console.WriteLine("What's your name?");
        response = Console.ReadLine();
        Console.WriteLine($"Enjoy the course, {response}");

        OperatingSystem thisOS = Environment.OSVersion;
        Console.WriteLine(thisOS.Platform);
        Console.WriteLine(thisOS.VersionString);
    }
}
