// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    { 
        Console.WriteLine("Enter the radius:");
        var r=Console.ReadLine();
        var radius=double.Parse(r);
        double area=calculate_area(radius);
        Console.WriteLine("The area of circle is:"+area);
        //Console.ReadKey();
        //create instance of class
        //var Circle=new Shape();
    }
    static double calculate_area(double r){
        const double pi=3.14;
        return (pi*r*r);
    }
    
    
}
