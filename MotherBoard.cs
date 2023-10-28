// 5436270
// Program 1
// Due 10/02/2023
// CIS 200-75

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// MotherBoard class takes Manufacturer, Model, Socket, PowerDraw to create and validate MotherBoard objects
namespace Prog1
{
    class MotherBoard
    {
        private string manufacturer;
        private string model;
        private string socket;
        private int powerDraw;

        // preconditions: String properties not null or empty, int properties >= 0
        // postconditions: New MotherBoard object is created
        public MotherBoard(string manufacturer, string model, string socket, int powerDraw)
        {
            Manufacturer = manufacturer;
            Model = model;
            Socket = socket;
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

        public string Socket
        {
            // preconditions: socket property is not null or empty
            // post conditions: socket property is valid and returned
            get { return socket; }

            // preconditions: a value for socket property has been inputted
            // post conditions: returns value without white space if value is not null or empty. returns exception of value is null or empty
            set
            {
                // validates string is not null or empty
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Socket)} cannot be empty.");

                // removes any leading or trailing white space
                socket = value.Trim();
            }
        }
        public int PowerDraw
        {
            // preconditions: value entered is >= 0
            // post conditions: power draw property is valid and returned
            get { return powerDraw; }

            // preconditions: value for power draw property has been inputted
            // post conditions: returns value if >= 0. returns exception if value < 0.
            set
            {
                // ensures power draw is not negative
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PowerDraw)} must be an integer > 0.");

                powerDraw = value;
            }
        }

        // overrides ToString method to display object's properties
        // preconditions: when called, object referenced must have already been created
        // post conditions: returns string representation of all properties of a MotherBoard object
        public override string ToString()
        {
            return $"Manufacturer:{Manufacturer}\nModel: {Model}\nSocket: {Socket} MB\nPower Draw: {PowerDraw} Watt";
        }
    }
}
