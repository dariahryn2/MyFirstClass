using MyFirstClass;
using System;

class Program
{
    static void Main(string[] args)
    {
        Stoel rodeStoel = new Stoel("rood", 60);
        Console.WriteLine(rodeStoel.echoKleur());
        Console.WriteLine("De stoel heeft een zithoogte van: " + rodeStoel.getZithoogte());

        rodeStoel.verstellen(10);
        Console.WriteLine("Na verstellen is de zithoogte: " + rodeStoel.getZithoogte());
    }
}

