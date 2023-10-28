// 5436270
// Program 1
// Due 10/02/2023
// CIS 200-75


using System;


// Laptop class derived from Computer class. Takes Manufacturer, Laptop Model, Fixed TDP, CPU object to create and validate Laptop objects.
// Laptop class overrides Computer class's CalcTDP method. Currently just returns Fixed TDP value.
namespace Prog1
{
    class Laptop : Computer
    {
        private string laptopModel;
        private int fixedTDP;

        // constructor gets manufacturer and CPU object from base class Computer constructor
        // preconditions: CPU object being referenced has been created, string properties are not null or empty, int properties are >= 0
        // post conditions: new Laptop object is created
        public Laptop(string manufacturer, string laptopModel, CPU cpu, int fixedTDP) : base(manufacturer, cpu)
        {
            LaptopModel = laptopModel;
            FixedTDP = fixedTDP;
        }


        public string LaptopModel
        {
            // preconditions: laptop model property is not null or empty
            // post conditions: laptop model property is valid and returned
            get { return laptopModel; }

            // preconditions: value for laptop model property has been inputted
            // post conditions: returns value without white space if value is not null or empty. returns exception of value is null or empty.
            set
            {
                // validates string is not null or empty
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(LaptopModel)} cannot be empty.");
                }
                // removes any leading or trailing white space
                laptopModel = value.Trim();
            }
        }

        public int FixedTDP
        {
            // preconditions: value entered is >= 0
            // post conditions: fixed TDP property is valid and returned
            get { return fixedTDP; }

            // preconditions: value for fixed TDP property has been inputted
            // post conditions: returns value if >= 0. returns exception if value < 0.
            set
            {
                // ensures fixed tdp is not negative
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(FixedTDP)} must be an integer > 0.");

                fixedTDP = value;
            }
        }

        // preconditions: when called, object referenced has been created with valid TDP property
        // post conditions: currently just returns fixed TDP property
        public override double CalcTDP()
        {
            return FixedTDP;
        }

        // preconditions: when called, object referenced has been created
        // post conditions: returns string representation of Laptop's properties
        public override string ToString()
        {
            return base.ToString() + $"\nLaptop Model: {LaptopModel}\nFixed TDP: {FixedTDP} Watt";
        }
    }
}
