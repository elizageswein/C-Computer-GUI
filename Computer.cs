// 5436270
// Program 1
// Due 10/02/2023
// CIS 200-75


using System;
using System.Security.Cryptography;


// Computer class takes Manufacturer, CPU object (from CPU class) to create and validate Computer objects
// Computer class contains abstract method to calculate TDP for use in derived classes.
// Base class to derived classes: Laptop
namespace Prog1
{ 
    abstract class Computer
    {
        private string manufacturer;
        private CPU cpu;

        // constructor gets cpu object from CPU class
        // preconditions: Manufacturer not null, CPU object not null
        // postconditions: new computer object is created
        public Computer(string manufacturer, CPU cpu)
        {
            Manufacturer = manufacturer;
            CPU = cpu;
        }

        // string property contains Computer object's manufacturer
        public string Manufacturer
        {
            // preconditions: manufacturer property is not null or empty
            // post conditions: manufacturer property is valid and returned
            get { return manufacturer; }

            // preconditions: a value for manufacturer property has been inputted
            // post conditions: returns value without white space if value is not null or empty. returns exception if value is null or empty.
            set
            {
                // validates string is not null or empty
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Manufacturer)} cannot be empty.");
                }

                // removes any leading or trailing white space
                manufacturer = value.Trim();
            }
        }

        // property contains Computer object's cpu object from CPU class
        public CPU CPU
        {
            // preconditions: cpu object is not null or empty
            // post conditions: cpu object is returned
            get { return cpu; }

            // preconditions: cpu object has been created 
            // post conditions: returns cpu object
            set
            {
                // don't need to validate, as only valid objects can be passed in 
                cpu = value;
            }
        }

        // method to calculate Total Draw Power in derived classes
        // preconditions: none
        // post conditions: is further defined by derived classes to return Total Draw Power
        public abstract double CalcTDP();

        // overrides ToString method to display object's properties
        // preconditions: when called, object referenced must have already been created
        // post conditions: returns string representation of Computer's properties
        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}\n CPU: {CPU}";
        }
    }
}