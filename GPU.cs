// 5436270
// Program 1
// Due 10/02/2023
// CIS 200-75

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

// GPU class takes Manufacturer, Model, VRAM, PowerDraw to create and validate GPU objects
namespace Prog1
{
    class GPU
    {
        private string manufacturer;
        private string model;
        private int vram;
        private int powerDraw;

        // preconditions: String properties not null or empty, int properties >= 0
        // postconditions: New GPU object is created
        public GPU(string manufacturer, string model, int vram, int powerDraw)
        {
            Manufacturer = manufacturer;
            Model = model;
            VRAM = vram;
            PowerDraw = powerDraw;
        }

        public string Manufacturer
        {
            // preconditions: manufacturer property is not null or empty
            // post conditions: manufacturer property is valid and returned
            get { return manufacturer; }

            // preconditions: a value for manufacturer property has been inputted
            // post conditions: returns value without white space if value is not null or empty. returns exception of value is null or empty
            set
            {
                // validates string is not null or empty
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Manufacturer)} cannot be empty.");

                // removes any leading or trailing white space
                manufacturer = value.Trim();
            }
        }

        public string Model
        {
            // preconditions: manufacturer property is not null or empty
            // post conditions: manufacturer property is valid and returned
            get { return model; }

            // preconditions: a value for manufacturer property has been inputted
            // post conditions: returns value without white space if value is not null or empty. returns exception of value is null or empty
            set
            {
                // validates string is not null or empty
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Model)} cannot be empty.");

                // removes any leading or trailing white space
                manufacturer = value.Trim();
            }
        }

        public int VRAM
        {
            // preconditions: value entered is >= 0
            // post conditions: vram property is valid and returned
            get { return vram; }

            // preconditions: value for vram property has been inputted
            // post conditions: returns value if >= 0. returns exception if value < 0.
            set
            {
                // ensures power draw is not negative
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(VRAM)} must be an integer from 0 - 2,000.");

                vram = value;
            }
        }

        public int PowerDraw
        {
            // preconditions: value entered is >= 0
            // post conditions: power draw property is valid and returned
            get { return powerDraw; }

            // preconditions: value for power draw property has been inputted
            // post conditions: returns value if in 0-2,000. returns exception if not.
            set
            {
                // ensures power draw is not negative
                if (value < 0 || value > 2000)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PowerDraw)} must be an integer from 0 - 2,000.");

                powerDraw = value;
            }
        }

        // overrides ToString method to display object's properties
        // preconditions: when called, object referenced must have already been created
        // post conditions: returns string representation of all properties of a GPU object
        public override string ToString()
        {
            return $"Manufacturer:{Manufacturer}\nModel: {Model}\nVRAM: {VRAM} MB\nPower Draw: {PowerDraw} Watt";
        }
    }
}

