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

// AllInOne class derived from Desktop class. Takes Manufacturer, CPU object, GPU object, MotherBoard object, FanCount, ScreenXSize, ScreenYSize to create and validate AllInOne objects.
// AllInOne class overrides Computer class's CalcTDP method to calculate AllInOne object's Total Draw Power.
namespace Prog1
{
    class AllInOne : Desktop
    {
        private int screenXSize;
        private int screenYSize;

        public AllInOne(string manufacturer, CPU cpu, GPU gpu, MotherBoard motherboard, int fanCount, int screenXSize, int screenYSize)
        : base(manufacturer, cpu, gpu, motherboard, fanCount)
        {
            ScreenXSize = screenXSize;
            ScreenYSize = screenYSize;
        }

        public int ScreenXSize
        {
            // preconditions: value entered is >= 0
            // post conditions: screenXSize property is valid and returned
            get { return screenXSize; }

            set
            {
                // ensures screenXSize is not negative
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(ScreenXSize)} must be an integer >0");

                screenXSize = value;
            }
        }

        public int ScreenYSize
        {
            // preconditions: value entered is >= 0
            // post conditions: screenYize property is valid and returned
            get { return screenYSize; }

            set
            {
                // ensures screenYSize is not negative
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(ScreenYSize)} must be an integer >0");

                screenYSize = value;
            }
        }

        // preconditions: object referenced has valid screenXsize and screenYsize properties
        // postconditions: returns Aspect Ratio string in X:Y format
        public string AspectRatio => $"{ScreenXSize}:{ScreenYSize}";

        // preconditions: when called, object referenced has been created with valid properties
        // post conditions: returns combined power draw of CPU, GPU, MotherBoard, and screen size
        public override double CalcTDP()
        {
            return CPU.PowerDraw + GPU.PowerDraw + MotherBoard.PowerDraw + (0.000042 * (ScreenXSize * ScreenYSize));
        }

        // preconditions: when called, object referenced has been created
        // post conditions: returns string representation of AllInOne's properties
        public override string ToString()
        {
            return base.ToString() + $"\nScreenXSize: {ScreenXSize}\nScreenYSize: {ScreenYSize}";
        }
    }
}

