// 5436270
// Program 1
// Due 10/02/2023
// CIS 200-75


using System;


// CPU class takes Manufactuere, Model, Clock Speed, Socket, Power Draw to create and validate CPU objects
namespace Prog1
{
    class CPU
    {
        private string manufacturer;
        private string model;
        private int clockSpeed;
        private string socket;
        private int powerDraw;


        // preconditions: String properties not null or empty, int properties >= 0
        // postconditions: New CPU object is created
        public CPU(string manufacturer, string model, int clockSpeed, string socket, int powerDraw)
        {
            // implicit call to computer constructor
            Manufacturer = manufacturer;
            Model = model;
            ClockSpeed = clockSpeed;
            Socket = socket;
            PowerDraw = powerDraw;
        }

        // overload constructor without parameter
        // preconditions: String properties (excluding manufacturer) not null or empty, int properties >= 0
        // post conditions: new CPU object is created
        public CPU(string model, int clockSpeed, string socket, int powerDraw)
        {
            // implicit call to computer constructor
            // sets manufacturer property to empty
            Manufacturer = string.Empty;
            Model = model;
            ClockSpeed = clockSpeed;
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
            // preconditions: model property is not null or empty
            // post conditions: model property is valid and returned
            get { return model; }

            // preconditions: a value for model property has been inputted
            // post conditions: returns value without white space if value is not null or empty. returns exception of value is null or empty
            set
            {
                // validates string is not null or empty
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Model)} cannot be empty.");

                // removes any leading or trailing white space
                model = value.Trim();
            }
        }

        public int ClockSpeed
        {
            // preconditions: value entered is >= 0
            // post conditions: clock speed property is valid and returned
            get { return clockSpeed; }

            // preconditions: value for clock speed property has been inputted
            // post conditions: returns value if >= 0. returns exception if value < 0.
            set
            {
                // ensures clock speed is not negative
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(ClockSpeed)} must be an integer > 0.");

                clockSpeed = value;
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
        // post conditions: returns string representation of all properties of a CPU object
        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}\nModel: {Model}\nClock Speed: {ClockSpeed} MHz\nSocket: {Socket}\nPower Draw: {PowerDraw} Watt";
        }
    }
}
