using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{

		public int year { get; set; } = 1;
		public string make { get; set; } = "Chevrolet";
		public string model { get; set; } = "Silverado";

		public abstract void DriveAbstract();

		public virtual void DriveVirtual()
        {
            Console.WriteLine($"I have one {year } {make } {model } in stock");
        }

    }
}

/*
            * Create an abstract class called Vehicle
            * The vehicle class shall have three string properties Year, Make, and Model
            * Set the defaults to something generic in the Vehicle class
            * Vehicle shall have an abstract method called DriveAbstract with no implementation
            * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
            */