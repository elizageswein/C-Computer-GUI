// 5436270
// Program 1
// Due 10/02/2023
// CIS 200-75
using Prog1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Desktop class derived from Computer class. Takes Manufacturer, CPU object, GPU object, MotherBoard object, FanCount to create and validate Desktop objects.
// Desktop class CPUCheck determines if CPU socket and MotherBoard socket match.
namespace Prog1
{
    abstract class Desktop : Computer
    {
        private GPU gpu;
        private MotherBoard motherBoard;
        private int fanCount;

        // constructor gets manufacturer and CPU object from base class Computer constructor
        // preconditions: CPU, GPU, MotherBoard objects being referenced have been created, string properties are not null or empty, int properties are >= 0
        // post conditions: new Desktop object is created
        public Desktop(string manufacturer, CPU cpu, GPU gpu, MotherBoard motherBoard, int fanCount) : base(manufacturer, cpu)
        {
            GPU = gpu;
            MotherBoard = motherBoard;
            FanCount = fanCount;
        }

        public GPU GPU
        {
            // preconditions: gpu object is not null or empty
            // post conditions: gpu object is returned
            get { return gpu; }

            // preconditions: gpu object has been created 
            // post conditions: returns gpu object
            set
            {
                // don't need to validate, as only valid objects can be passed in 
                gpu = value;
            }
        }

        public MotherBoard MotherBoard
        {
            // preconditions: gpu object is not null or empty
            // post conditions: gpu object is returned
            get { return motherBoard; }

            // preconditions: gpu object has been created 
            // post conditions: returns gpu object
            set
            {
                // don't need to validate, as only valid objects can be passed in 
                motherBoard = value;
            }
        }

        public int FanCount
        {
            // preconditions: value entered is >= 0
            // post conditions: fixed TDP property is valid and returned
            get { return fanCount; }

            // preconditions: value for fixed TDP property has been inputted
            // post conditions: returns value if >= 0. returns exception if value < 0.
            set
            {
                // ensures fixed tdp is not negative
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(FanCount)} must be an integer > 0");

                fanCount = value;
            }
        }

        // preconditions: when called, objects referenced have been created with valid Socket properties
        // post conditions: returns "True" if CPU and MotherBoard sockets match, "False" if they do not match
        public bool CPUCheck()
        {
            return CPU.Socket == MotherBoard.Socket;
        }

        // preconditions: when called, object referenced has been created
        // post conditions: returns string representation of Desktop's properties
        public override string ToString()
        {
            return base.ToString() + $"GPU: {GPU}\n Motherboard: {MotherBoard}\n Fans: {FanCount}";
        }
    }
}
